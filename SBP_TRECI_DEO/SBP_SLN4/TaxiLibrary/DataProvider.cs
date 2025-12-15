namespace TaxiLibrary;

public class DataProvider
{
    #region BrojeviTelefona

    public static Result<List<Dictionary<int, string>>, ErrorMessage> GetBrojInfos()
    {
        ISession? session = null;
        List<BrojeviTelefonaView> brojInfo = [];
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            var brojeviTelefona = session.Query<BrojeviTelefona>().ToList();

            var brojeviTelefonaView = brojeviTelefona.Select(bt => new BrojeviTelefonaView
            {
                Id = new BrojeviTelefonaIdView
                {
                    Osoba = new OsobaView
                    {
                        OsobaId = bt.BrojTelefona.Osoba.ID_Osobe,
                        ulica = bt.BrojTelefona.Osoba.Ulica,
                        broj = bt.BrojTelefona.Osoba.Broj,
                        Tip_Osobe = bt.BrojTelefona.Osoba.TipOsobe
                    },
                    BrTel = bt.BrojTelefona.BrojTelefona
                }
            }).ToList();

            //Logovanje da vidimo koji se podaci vracaju
            List<Dictionary<int, string>> bt1 = new List<Dictionary<int, string>>();
            foreach (var bt in brojeviTelefonaView)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(bt.Id.Osoba.OsobaId, bt.Id.BrTel);
                bt1.Add(dict);
                Console.WriteLine($"Osoba ID: {bt.Id.Osoba.OsobaId}, Broj telefona: {bt.Id.BrTel}");

            }

            return bt1;
        }
        catch (Exception ex)
        {
            return $"Nemoguce preuzeti brojeve telefona. Greska: {ex.Message}".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<bool, ErrorMessage>> dodajBrojTelefona(BrojeviTelefonaView ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            if (ob == null)
            {
                return "Input object is null.".ToError(400);
            }
            if (ob.Id == null)
            {
                return "Id object is null.".ToError(400);
            }
            if (ob.Id.Osoba == null)
            {
                return "Osoba object is null.".ToError(400);
            }
            if (string.IsNullOrEmpty(ob.Id.BrTel))
            {
                return "Broj telefona is null or empty.".ToError(400);
            }

            // Kreiramo novi broj telefona sa kompozitnim kljucem
            var osoba = await session.LoadAsync<Osoba>(ob.Id.Osoba.OsobaId);
            if (osoba == null)
            {
                return $"Osoba with ID {ob.Id.Osoba.OsobaId} not found.".ToError(404);
            }

            BrojeviTelefona brojTelefona = new BrojeviTelefona
            {
                BrojTelefona = new BrojeviTelefonaId
                {
                    Osoba = osoba,
                    BrojTelefona = ob.Id.BrTel
                }
            };

            await session.SaveAsync(brojTelefona);
            await session.FlushAsync();
            return true;
        }
        catch (Exception ex)
        {
            return ex.Message.ToError(404); //poruka u svrhu debagovanja 
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<bool, ErrorMessage>> DeleteBrojTelefona(BrojeviTelefonaView ob)
    {
        ISession? session = null;
        ITransaction? transaction = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            if (ob == null || ob.Id == null || ob.Id.Osoba == null)
            {
                return "Invalid input data.".ToError(400);
            }

            var osoba = await session.LoadAsync<Osoba>(ob.Id.Osoba.OsobaId);
            if (osoba == null)
            {
                return $"Osoba with ID {ob.Id.Osoba.OsobaId} not found.".ToError(404);
            }

            transaction = session.BeginTransaction();

            var brojTelefona = await session.GetAsync<BrojeviTelefona>(new BrojeviTelefonaId { Osoba = osoba, BrojTelefona = ob.Id.BrTel });
            if (brojTelefona == null)
            {
                return $"Broj telefona {ob.Id.BrTel} for osoba ID {ob.Id.Osoba.OsobaId} not found.".ToError(404);
            }

            await session.DeleteAsync(brojTelefona);
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception ex)
        {
            if (transaction != null)
            {
                await transaction.RollbackAsync();
            }
            return ex.Message.ToError(404);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    #endregion
}