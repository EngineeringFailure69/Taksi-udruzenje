namespace TaxiLibrary;

public class DataProvider
{
    #region Upravlja
    public static Result<List<UpravljaView>, ErrorMessage> GetUprInfos()
    {
        List<UpravljaView> upravljanjaInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Upravlja> upravljanja =
                    from o in session.Query<Upravlja>()
                    select o;

                foreach (Upravlja o in upravljanja)
                {
                    if (o.ZaposleniVozac != null && o.Vozilo != null)
                    {
                        upravljanjaInfos.Add(new UpravljaView(o.ID_Upravljanja, o.Vozilo.ID_Vozila, o.ZaposleniVozac.ID_Osobe, o.DatumOd, o.DatumDo));
                    }
                }
            }

        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti sva upravljanja.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return upravljanjaInfos;
    }
    public static async Task<Result<bool, ErrorMessage>> dodajUpravljanje(UpravljaView ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            if (session != null && ob != null)
            {
                Upravlja o = new Upravlja
                {
                    Vozilo = await session.LoadAsync<Vozilo>(ob.IdVozilo),
                    ZaposleniVozac = await session.LoadAsync<Zaposleni>(ob.IdVozac),
                    DatumOd = ob.DatOd,
                    DatumDo = ob.DatDo
                };

                await session.SaveAsync(o);
                await session.FlushAsync();
                return true;
            }
            else
            {
                return "Session or UpravljaView object is null.".ToError(400);
            }
        }
        catch (Exception)
        {
            return GetError("Nemoguce dodati voznju.", 404);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<UpravljaView?, ErrorMessage>> UpdateUpravlja(UpravljaView? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null && ob != null)
            {
                Upravlja o = await session.LoadAsync<Upravlja>(ob.UpravljaId);
                o.Vozilo = await session.LoadAsync<Vozilo>(ob.IdVozilo);
                o.ZaposleniVozac = await session.LoadAsync<Zaposleni>(ob.IdVozac);
                o.DatumOd = ob.DatOd;
                o.DatumDo = ob.DatDo;

                await session.UpdateAsync(o);
                await session.FlushAsync();
            }
        }
        catch (Exception ex)
        {
            return "Nemoguce azurirati upravljanje.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return ob;
    }
    public static Result<UpravljaView, ErrorMessage> GetUpravljanje(int idupravlja)
    {
        UpravljaView ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                Upravlja o = session.Load<Upravlja>(idupravlja);
                ob = new UpravljaView(o.ID_Upravljanja, o.Vozilo.ID_Vozila, o.ZaposleniVozac.ID_Osobe, o.DatumOd, o.DatumDo);
            }
        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti upravljanje.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return ob;
    }
    public static Result<List<UpravljaView>, ErrorMessage> GetIstorijaUpravlja(int idvozila)
    {
        List<UpravljaView> upravljanjaInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Upravlja> upravljanja =
                    from o in session.Query<Upravlja>()
                    where o.Vozilo.ID_Vozila == idvozila
                    select o;

                foreach (Upravlja o in upravljanja)
                {
                    if (o.ZaposleniVozac != null && o.Vozilo != null)
                    {
                        upravljanjaInfos.Add(new UpravljaView(o.ID_Upravljanja, o.Vozilo.ID_Vozila, o.ZaposleniVozac.ID_Osobe, o.Vozilo.RegistarskaOznaka, o.DatumOd, o?.DatumDo));
                    }
                }
            }

        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti istoriju upravljanja.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return upravljanjaInfos;
    }

    #endregion

    #region Vozilo
    public static Result<List<VoziloView>, ErrorMessage> GetVoziloInfos()
    {
        List<VoziloView> voziloInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (session == null || !session.IsConnected)
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            if (session != null)
            {
                IEnumerable<Vozilo> vozila =
                    from o in session.Query<Vozilo>()
                    select o;

                foreach (Vozilo o in vozila)
                {
                    voziloInfos.Add(new VoziloView(o.ID_Vozila, o.Marka, o.Tip, o.TipVozila, o.GodinaProizvodnje, o.DatumIstekaRegistracije, o.RegistarskaOznaka, o.Zaposleni?.ID_Osobe, o.Zaposleni != null ? o.Zaposleni.Lime : "Nema vlasnika", o.Boja));
                }
            }

        }
        catch (Exception)
        {
            return "Nemoguce vratiti sva vozila.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return voziloInfos;
    }
    public static async Task<Result<bool, ErrorMessage>> dodajVozilo(VoziloView ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
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
                    Boja = ob.boja
                };

                if (ob.VlasnikId.HasValue)
                {
                    o.Zaposleni = await session.LoadAsync<Zaposleni>(ob.VlasnikId.Value);
                }

                await session.SaveAsync(o);
                await session.FlushAsync();
                return true;
            }
            else
            {
                return "Session or UpravljaView object is null.".ToError(400);
            }
        }
        catch (Exception)
        {
            return GetError("Nemoguce dodati vozilo.", 404);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<VoziloView?, ErrorMessage>> UpdateVozilo(VoziloView? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
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
            return "Nemoguce azurirati vozilo.".ToError(400);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    public static Result<VoziloView, ErrorMessage> GetVozilo(int idvozila)
    {
        VoziloView ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                Vozilo o = session.Load<Vozilo>(idvozila);
                ob = new VoziloView(o.ID_Vozila, o.Marka, o.Tip, o.TipVozila, o.GodinaProizvodnje,
                    o.DatumIstekaRegistracije, o.RegistarskaOznaka, o.Zaposleni != null ? o.Zaposleni.ID_Osobe : null, o.Boja);
            }
        }
        catch (Exception)
        {
            return "Nemoguce vratiti vozilo.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return ob;
    }
    public static Result<List<VoziloView>, ErrorMessage> GetVoziloMarka(string marka)
    {
        List<VoziloView> voziloInfo = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Vozilo> vozila =
                    from o in session.Query<Vozilo>()
                    where o.Marka != null && o.Marka == marka
                    select o;

                foreach (Vozilo o in vozila)
                {
                    voziloInfo.Add(new VoziloView(o.ID_Vozila, o.Marka, o.Tip, o.TipVozila, o.GodinaProizvodnje,
                    o.DatumIstekaRegistracije, o.RegistarskaOznaka, o.Zaposleni != null ? o.Zaposleni.ID_Osobe : null, o.Boja));
                }
            }

        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti vozila.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return voziloInfo;
    }
    #endregion

    #region Musterija

    public static Result<List<MusterijaView>, ErrorMessage> GetMusterijaInfos()
    {
        List<MusterijaView> musterijaInfo = new List<MusterijaView>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Musterija> musterije =
                from o in session.Query<Musterija>()
                select o;

                foreach (Musterija m in musterije)
                {
                    musterijaInfo.Add(new MusterijaView(
                        m.ID_Osobe,
                        m.Ulica,
                        m.Broj,
                        m.TipOsobe,
                        m.BrKoriscenihVoznji));
                }
            }
        }
        catch (Exception ex)
        {
            return $"Nemoguce vratiti sve zaposlene. {ex.Message}".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return musterijaInfo;
    }
    public static Result<MusterijaView, ErrorMessage> GetMusterija(int idmusterije)
    {
        MusterijaView ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                Musterija o = session.Load<Musterija>(idmusterije);
                ob = new MusterijaView(o.ID_Osobe, o.Ulica, o.Broj, o.TipOsobe, o.BrKoriscenihVoznji);
            }
        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti musteriju.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return ob;
    }
    public static Result<List<MusterijaView>, ErrorMessage> GetMusterijaVoznje(int voznje)
    {
        List<MusterijaView> musterijaInfo = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Musterija> musterije =
                    from o in session.Query<Musterija>()
                    where o.BrKoriscenihVoznji == voznje
                    select o;

                foreach (Musterija m in musterije)
                {
                    musterijaInfo.Add(new MusterijaView(m.ID_Osobe, m.Ulica, m.Broj, m.TipOsobe, m.BrKoriscenihVoznji));
                }
            }

        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti musteriju".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return musterijaInfo;
    }
    public static async Task<Result<bool, ErrorMessage>> UpdateMusterija(MusterijaView? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            if (ob == null || ob.OsobaId <= 0)
            {
                return "Invalid input data.".ToError(400);
            }

            var musterija = await session.LoadAsync<Musterija>(ob.OsobaId);
            if (musterija == null)
            {
                return $"Musterija with ID {ob.OsobaId} not found.".ToError(404);
            }

            musterija.Ulica = ob.ulica;
            musterija.Broj = ob.broj;
            musterija.TipOsobe = ob.Tip_Osobe ?? "Musterija";
            musterija.BrKoriscenihVoznji = ob.Br_Koriscenih_Voznji;

            await session.SaveOrUpdateAsync(musterija);
            await session.FlushAsync();

            return true;
        }
        catch (Exception ex)
        {
            return ex.Message.ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<bool, ErrorMessage>> dodajMusteriju(MusterijaView ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null && ob != null)
            {
                ob.Tip_Osobe = "Musterija";

                Musterija o = new Musterija
                {
                    Ulica = ob.ulica,
                    Broj = ob.broj,
                    TipOsobe = ob.Tip_Osobe,
                    BrKoriscenihVoznji = ob.Br_Koriscenih_Voznji
                };

                await session.SaveAsync(o);
                await session.FlushAsync();

                BrojeviTelefona brojTelefona = new BrojeviTelefona
                {
                    BrojTelefona = new BrojeviTelefonaId
                    {
                        Osoba = o,
                        BrojTelefona = ob.BrojTelefona
                    }
                };

                await session.SaveAsync(brojTelefona);
                await session.FlushAsync();
                return true;
            }
            else
            {
                return "Session or MusterijaView object is null.".ToError(400);
            }
        }
        catch (Exception ex)
        {
            return GetError("Nemoguce dodati musteriju.", 404);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static Result<List<MusterijaView>, ErrorMessage> GetMusterijaPopustInfos()
    {
        List<MusterijaView> musterijaInfo = new List<MusterijaView>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Musterija> musterije = from o in session.Query<Musterija>()
                                                   where o.BrKoriscenihVoznji >= 10
                                                   select o;

                foreach (Musterija m in musterije)
                {
                    musterijaInfo.Add(new MusterijaView(
                        m.ID_Osobe,
                        m.Ulica,
                        m.Broj,
                        m.TipOsobe,
                        m.BrKoriscenihVoznji
                        ));
                }
            }
        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti musterije".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return musterijaInfo;
    }

    #endregion

    #region Voznja
    public static Result<List<VoznjaView>, ErrorMessage> GetVoznjaInfos()
    {
        List<VoznjaView> voznjaInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session == null || !session.IsConnected)
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                IEnumerable<Voznja> voznje = session.Query<Voznja>().ToList();

                foreach (Voznja o in voznje)
                {
                    voznjaInfos.Add(new VoznjaView(o));
                }
            }

        }
        catch (Exception)
        {
            return "Nemoguce vratiti sve voznje.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return voznjaInfos;
    }
    public static async Task<Result<bool, ErrorMessage>> dodajVoznju(VoznjaView ob)
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

            transaction = session.BeginTransaction();

            Musterija musterija = await session.GetAsync<Musterija>(ob.MusterijaId);
            if (musterija == null)
            {
                return "Musterija sa ovim ID ne postoji".ToError(400);
            }

            musterija.BrKoriscenihVoznji += 1;

            Voznja o = new Voznja
            {
                Musterija = await session.LoadAsync<Musterija>(ob.MusterijaId),
                PocetnaStanica = ob.Pocetna_Stanica,
                KrajnjaStanica = ob.Kranja_Stanica,
                BrTelNarucivanja = ob.Br_Tel_Narucivanja,
                ZaposleniAdmin = await session.LoadAsync<Zaposleni>(ob.AdminId),
                VremeJavljanja = ob.Vreme_Javljanja,
                BrTelPrimljenogPoziva = ob.Br_Tel_Prim_Poziva,
                ZaposleniVozac = await session.LoadAsync<Zaposleni>(ob.VozacId),
                VremePocetka = ob.Vreme_Pocetka,
                VremeKraja = ob.Vreme_Kraja
            };

            await session.UpdateAsync(musterija);

            await session.SaveAsync(o);
            await transaction.CommitAsync();
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            if (transaction != null)
            {
                await transaction.RollbackAsync();
            }
            return GetError("Nemoguce dodati voznju.", 404);
        }
        finally
        {
            session?.Close();
        }
    }
    public static async Task<Result<VoznjaView, ErrorMessage>> UpdateVoznja(VoznjaView? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null && ob != null)
            {
                Voznja o = await session.LoadAsync<Voznja>(ob.VoznjaId);
                o.Musterija = await session.LoadAsync<Musterija>(ob.MusterijaId);
                o.PocetnaStanica = ob.Pocetna_Stanica;
                o.KrajnjaStanica = ob.Kranja_Stanica;
                o.BrTelNarucivanja = ob.Br_Tel_Narucivanja;
                o.ZaposleniAdmin = await session.LoadAsync<Zaposleni>(ob.AdminId);
                o.VremeJavljanja = ob.Vreme_Javljanja;
                o.BrTelPrimljenogPoziva = ob.Br_Tel_Prim_Poziva;
                o.ZaposleniVozac = await session.LoadAsync<Zaposleni>(ob.VozacId);
                o.VremePocetka = ob.Vreme_Pocetka;
                o.VremeKraja = ob.Vreme_Kraja;

                await session.UpdateAsync(o);
                await session.FlushAsync();
            }
        }
        catch (Exception)
        {
            return "Nemoguce azurirati voznju.".ToError(400);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    public static async Task<Result<VoznjaView, ErrorMessage>> GetVoznja(int idvoznje)
    {
        VoznjaView ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }
            if (session != null)
            {
                Voznja o = await session.LoadAsync<Voznja>(idvoznje);
                ob = new VoznjaView(o);
            }
        }
        catch (Exception)
        {
            return "Nemoguce je vratiti trazene podatke".ToError(400);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    public static async Task<Result<bool, ErrorMessage>> obrisiVoznju(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            Voznja o = await s.LoadAsync<Voznja>(id);

            await s.DeleteAsync(o);
            await s.FlushAsync();

            s.Close();
            s.Dispose();
            return true;
        }
        catch (Exception)
        {
            return "Nemoguce obrisati voznju.".ToError(400);
        }
    }

    #endregion

    #region Osoba
    public static Result<List<OsobaView>, ErrorMessage> GetOsobaInfos()
    {
        List<OsobaView> osobaInfo = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Osoba> osobe =
                    from o in session.Query<Osoba>()
                    select o;

                foreach (Osoba o in osobe)
                {
                    osobaInfo.Add(new OsobaView(o.ID_Osobe, o.Ulica, o.Broj, o.TipOsobe));
                }
            }

        }
        catch (Exception ex)
        {
            return "Nemoguce vratiti sve osobe.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return osobaInfo;
    }
    public static async Task<Result<OsobaView, ErrorMessage>> UpdateOsoba(OsobaView? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                Osoba o = await session.LoadAsync<Osoba>(ob.OsobaId);
                o.Ulica = ob.ulica;
                o.Broj = ob.broj;

                await session.UpdateAsync(o);
                await session.FlushAsync();
            }
        }
        catch (Exception)
        {
            return "Nemoguce azurirati osobu.".ToError(400);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    #endregion

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

    #region Kategorije

    public static Result<List<Dictionary<int, string>>, ErrorMessage> GetKategorijeInfos()
    {
        ISession? session = null;
        List<KategorijaView> brojInfo = [];
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.".ToError(403);
            }

            var kategorije = session.Query<Kategorije>().ToList();

            var kategorijeView = kategorije.Select(bt => new KategorijaView
            {
                Id = new KategorijaIdView
                {
                    Zaposleni = new ZaposleniView
                    {
                        OsobaId = bt.Kategorija.Zaposleni.ID_Osobe,
                        lime = bt.Kategorija.Zaposleni.Lime,
                        SrSlovo = bt.Kategorija.Zaposleni.SrednjeSlovo,
                        prezime = bt.Kategorija.Zaposleni.Prezime,
                        jmbg = bt.Kategorija.Zaposleni.JMBG,
                        Tip_Zaposlenog = bt.Kategorija.Zaposleni.TipZaposlenog,
                        Broj_Vozacke = bt.Kategorija.Zaposleni.BrojVozacke,
                        Strucna_Sprema = bt.Kategorija.Zaposleni.StrucnaSprema,
                    },
                    Kategorija = bt.Kategorija.Kategorija,
                }
            }).ToList();

            List<Dictionary<int, string>> bt1 = new List<Dictionary<int, string>>();
            foreach (var bt in kategorijeView)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(bt.Id.Zaposleni.OsobaId, bt.Id.Kategorija);
                bt1.Add(dict);
                Console.WriteLine($"Zaposleni ID: {bt.Id.Zaposleni.OsobaId}, kategorija: {bt.Id.Kategorija}");

            }

            return bt1;
        }
        catch (Exception ex)
        {
            return $"Nemoguce preuzeti kategorije. Greska: {ex.Message}".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<bool, ErrorMessage>> dodajKategoriju(KategorijaView ob)
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

            if (ob == null || ob.Id == null || ob.Id.Zaposleni == null)
            {
                return "Invalid input object or missing required data.".ToError(400);
            }

            var zaposleniId = ob.Id.Zaposleni?.OsobaId;
            if (zaposleniId == null)
            {
                return "Zaposleni ID is null.".ToError(400);
            }

            var zaposleni = await session.LoadAsync<Zaposleni>(zaposleniId);
            if (zaposleni == null)
            {
                return $"Zaposleni with ID {zaposleniId} not found.".ToError(404);
            }

            Kategorije novaKategorija = new Kategorije
            {
                Kategorija = new KategorijaId
                {
                    Zaposleni = zaposleni,
                    Kategorija = ob.Id.Kategorija 
                }
            };

            transaction = session.BeginTransaction();
            await session.SaveAsync(novaKategorija);
            await transaction.CommitAsync();

            return true;
        }
        catch (Exception ex)
        {
            if (transaction != null)
            {
                await transaction.RollbackAsync();
            }
            return ex.Message.ToError(500); //500 za neocekivane greske
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<bool, ErrorMessage>> DeleteKategorija(KategorijaView ob)
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

            if (ob == null || ob.Id == null || ob.Id.Zaposleni == null || string.IsNullOrEmpty(ob.Id.Kategorija))
            {
                return "Invalid input data.".ToError(400);
            }

            var zaposleni = await session.LoadAsync<Zaposleni>(ob.Id.Zaposleni.OsobaId);
            if (zaposleni == null)
            {
                return $"Zaposleni with ID {ob.Id.Zaposleni.OsobaId} not found.".ToError(404);
            }

            transaction = session.BeginTransaction();

            var kategorija = await session.GetAsync<Kategorije>(new KategorijaId
            {
                Zaposleni = zaposleni,
                Kategorija = ob.Id.Kategorija
            });

            if (kategorija == null)
            {
                return $"Kategorija {ob.Id.Kategorija} for zaposleni ID {ob.Id.Zaposleni.OsobaId} not found.".ToError(404);
            }

            await session.DeleteAsync(kategorija);

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