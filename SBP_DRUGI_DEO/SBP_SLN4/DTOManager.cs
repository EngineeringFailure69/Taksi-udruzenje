using System.Runtime.CompilerServices;

namespace SBP_SLN4;

public class DTOManager
{

    #region Vozilo
    public static List<VoziloPregled> GetVoziloInfos()
    {
        List<VoziloPregled> voziloInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Vozilo> vozila =
                    from o in session.Query<Vozilo>()
                    select o;

                foreach (Vozilo o in vozila)
                {
                        voziloInfos.Add(new VoziloPregled(o.ID_Vozila, o.Marka, o.TipVozila, o.RegistarskaOznaka, o.Zaposleni!=null ? o.Zaposleni.Lime:"Nema vlasnika", o.Boja));
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }

        return voziloInfos;
    }
    public static async Task dodajVozilo(VoziloBasic ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                Vozilo o = new Vozilo
                {
                    Marka = ob.marka,
                    Tip = ob.tip,
                    TipVozila = ob.tipVozila,
                    GodinaProizvodnje = ob.godinaProizvodnje,
                    DatumIstekaRegistracije = ob.DatIstekaReg,
                    RegistarskaOznaka = ob.RegOznaka,
                    Boja=ob.boja
                };

                if (ob.VlasnikId.HasValue)
                {
                    o.Zaposleni = await session.LoadAsync<Zaposleni>(ob.VlasnikId.Value);
                }

                await session.SaveAsync(o);
                await session.FlushAsync();
            }
            else
            {
                MessageBox.Show("Session or VoziloBasic object is null.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }
    }
    public static async Task<VoziloBasic?> UpdateVoziloBasic(VoziloBasic? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                Vozilo o = await session.LoadAsync<Vozilo>(ob.VoziloId);
                o.Marka = ob.marka;
                o.Tip = ob.tip;
                o.TipVozila = ob.tipVozila;
                o.GodinaProizvodnje = ob.godinaProizvodnje;
                o.DatumIstekaRegistracije = ob.DatIstekaReg;
                o.RegistarskaOznaka = ob.RegOznaka;
                o.Boja = ob.boja;
                if (ob.VlasnikId.HasValue)
                {
                    o.Zaposleni = await session.LoadAsync<Zaposleni>(ob.VlasnikId);
                }
                else 
                {
                    o.Zaposleni = null;
                }
                await session.UpdateAsync(o);
                await session.FlushAsync();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    public static async Task<VoziloBasic> GetVoziloBasic(int idvozila)
    {
        VoziloBasic ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                Vozilo o = await session.LoadAsync<Vozilo>(idvozila);
                ob = new VoziloBasic(o.ID_Vozila, o.Marka, o.Tip, o.TipVozila, o.GodinaProizvodnje, 
                    o.DatumIstekaRegistracije, o.RegistarskaOznaka, o.Zaposleni!=null?o.Zaposleni.ID_Osobe:null, o.Boja);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    #endregion

}