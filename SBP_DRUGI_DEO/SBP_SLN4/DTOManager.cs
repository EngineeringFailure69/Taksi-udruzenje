namespace SBP_SLN4;

public class DTOManager
{

    #region Upravlja
    public static List<UpravljaPregled> GetUprInfos()
    {
        List<UpravljaPregled> upravljanjaInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Upravlja> upravljanja =
                    from o in session.Query<Upravlja>()
                    select o;

                foreach (Upravlja o in upravljanja)
                {
                    if (o.ZaposleniVozac != null && o.Vozilo!=null)
                    {
                        upravljanjaInfos.Add(new UpravljaPregled(o.ID_Upravljanja, o.Vozilo.ID_Vozila, o.ZaposleniVozac.ID_Osobe, o.Vozilo.RegistarskaOznaka));
                    }
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

        return upravljanjaInfos;
    }
    public static async Task dodajUpravljanje(UpravljaBasic ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

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
            }
            else
            {
                MessageBox.Show("Session or UpravljaBasic object is null.");
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
    public static async Task<UpravljaBasic?> UpdateUpravljaBasic(UpravljaBasic? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

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
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }

        return ob;
    }
    public static async Task<UpravljaBasic> GetUpravljaBasic(int idupravlja)
    {
        UpravljaBasic ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                Upravlja o = await session.LoadAsync<Upravlja>(idupravlja);
                ob = new UpravljaBasic(o.ID_Upravljanja, o.Vozilo.ID_Vozila, o.ZaposleniVozac.ID_Osobe, o.DatumOd, o.DatumDo);
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
    public static List<UpravljaPregled> GetIstorijaUpravljaBasic(int idvozila)
    {
        List<UpravljaPregled> upravljanjaInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Upravlja> upravljanja =
                    from o in session.Query<Upravlja>()
                    where o.Vozilo.ID_Vozila== idvozila
                    select o;

                foreach (Upravlja o in upravljanja)
                {
                    if (o.ZaposleniVozac != null && o.Vozilo != null)
                    {
                        upravljanjaInfos.Add(new UpravljaPregled(o.ID_Upravljanja, o.Vozilo.ID_Vozila, o.ZaposleniVozac.ID_Osobe, o.Vozilo.RegistarskaOznaka));
                    }
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

        return upravljanjaInfos;
    }

    #endregion

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

    #region Zaposleni

    public static List<ZaposleniPregled> GetZaposleniInfos()
    {
        List<ZaposleniPregled> zaposleniInfo = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Zaposleni> zaposleni =
                    from o in session.Query<Zaposleni>()
                    select o;

                foreach (Zaposleni o in zaposleni)
                {
                    zaposleniInfo.Add(new ZaposleniPregled(o.ID_Osobe, o.Ulica, o.Broj, o.TipOsobe, o.Lime, o.SrednjeSlovo,
                        o.Prezime, o.JMBG, o.TipZaposlenog, o.BrojVozacke, o.StrucnaSprema));
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

        return zaposleniInfo;
    }
    public static async Task<ZaposleniBasic> GetZaposleniBasic(int idzaposlenog)
    {
        ZaposleniBasic ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                Zaposleni o = await session.LoadAsync<Zaposleni>(idzaposlenog);
                ob = new ZaposleniBasic(o.ID_Osobe, o.Ulica, o.Broj, o.TipOsobe, o.Lime, o.SrednjeSlovo, o.Prezime, o.JMBG,
                    o.TipZaposlenog, o.BrojVozacke, o.StrucnaSprema);
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
    public static async Task<ZaposleniBasic?> UpdateZaposleniBasic(ZaposleniBasic? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                Zaposleni o = await session.LoadAsync<Zaposleni>(ob.OsobaId);
                o.Ulica = ob.ulica;
                o.Broj = ob.broj;
                o.TipOsobe = ob.Tip_Osobe;
                o.Lime = ob.lime;
                o.SrednjeSlovo = ob.SrSlovo;
                o.Prezime = ob.prezime;
                o.JMBG = ob.jmbg;
                o.TipZaposlenog = ob.Tip_Zaposlenog;
                o.BrojVozacke = ob.Broj_Vozacke;
                o.StrucnaSprema = ob.Strucna_Sprema;

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
    public static async Task dodajZaposlenog(ZaposleniBasicBrojevi ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                // Kreiramo novog zaposlenog
                Zaposleni o = new Zaposleni
                {
                    Ulica = ob.ulica,
                    Broj = ob.broj,
                    TipOsobe = ob.Tip_Osobe = "Zaposleni",
                    Lime = ob.lime,
                    SrednjeSlovo = ob.SrSlovo,
                    Prezime = ob.prezime,
                    JMBG = ob.jmbg,
                    TipZaposlenog = ob.Tip_Zaposlenog,
                    BrojVozacke = ob.Broj_Vozacke,
                    StrucnaSprema = ob.Strucna_Sprema,
                };

                // Sacuvam novu musteriju
                await session.SaveAsync(o);
                await session.FlushAsync();

                // Kreiram i sacuvam novi broj telefona za musteriju
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
            }
            else
            {
                MessageBox.Show("Session or ZaposleniBasicBrojevi object is null.");
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

    #endregion

    #region Musterija

    public static async Task dodajMusteriju(MusterijaBasicBrojevi ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                Musterija o = new Musterija
                {
                    Ulica = ob.ulica,
                    Broj = ob.broj,
                    TipOsobe = "Musterija",
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
            }
            else
            {
                MessageBox.Show("Session or MusterijaBasicBrojevi object is null.");
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

    #endregion

    #region Voznja
    public static List<VoznjaPregled> GetVoznjaInfos()
    {
        List<VoznjaPregled> voznjaInfos = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Voznja> voznje =
                    from o in session.Query<Voznja>()
                    select o;

                foreach (Voznja o in voznje)
                {
                    voznjaInfos.Add(new VoznjaPregled(o.ID_Voznje, o.ZaposleniAdmin.ID_Osobe, o.ZaposleniVozac.ID_Osobe, o.Musterija.ID_Osobe,
                        o.PocetnaStanica, o.KrajnjaStanica, o.VremePocetka, o.VremeKraja, o.BrTelNarucivanja, o.ZaposleniVozac.Lime, o.ZaposleniAdmin.Lime));
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

        return voznjaInfos;
    }
    public static async Task dodajVoznju(VoznjaBasic ob)
    {
        ISession? session = null;
        ITransaction? transaction = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                transaction = session.BeginTransaction();

                Musterija musterija = await session.GetAsync<Musterija>(ob.MusterijaId);
                if (musterija == null)
                {
                    MessageBox.Show($"Musterija with ID {ob.MusterijaId} ne postoji.");
                    return;
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
            }
            else
            {
                MessageBox.Show("Session or VoznjaBasic object is null.");
            }
        }
        catch (Exception ex)
        {
            if (transaction != null)
            {
                await transaction.RollbackAsync();
            }
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }
    }
    public static async Task obrisiVoznju(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            Voznja o = s.Load<Voznja>(id);

            s.Delete(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }
    public static async Task<VoznjaBasic?> UpdateVoznjaBasic(VoznjaBasic? ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

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
    public static async Task<VoznjaBasic> GetVoznjaBasic(int idvoznje)
    {
        VoznjaBasic ob = new();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                Voznja o = await session.LoadAsync<Voznja>(idvoznje);
                ob = new VoznjaBasic(o.ID_Voznje, o.Musterija.ID_Osobe, o.PocetnaStanica, o.KrajnjaStanica, o.BrTelNarucivanja,
                    o.ZaposleniAdmin.ID_Osobe, o.VremeJavljanja, o.BrTelPrimljenogPoziva, o.ZaposleniVozac.ID_Osobe,
                    o.VremePocetka, o.VremeKraja);
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

    #region Osoba
    public static List<OsobaPregled> GetOsobaInfos()
    {
        List<OsobaPregled> osobaInfo = [];
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
                    osobaInfo.Add(new OsobaPregled(o.ID_Osobe, o.Ulica, o.Broj, o.TipOsobe));
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

        return osobaInfo;
    }

    #endregion

    #region Kategorije

    public static List<KategorijePregled> GetKategorijeInfos()
    {
        List<KategorijePregled> kategorijeInfo = [];
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                IEnumerable<Kategorije> kategorije =
                    from o in session.Query<Kategorije>()
                    select o;

                foreach (Kategorije o in kategorije)
                {
                    kategorijeInfo.Add(new KategorijePregled(o.Kategorija));
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

        return kategorijeInfo;
    }
    public static async Task dodajKategoriju(KategorijeBasic ob)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null && ob != null)
            {
                // Kreiram novi objekat Kategorija koristeci podatke iz objekta KategorijaBasic
                Kategorije novaKategorija = new Kategorije
                {
                    Kategorija = new KategorijaId
                    {
                        Zaposleni = session.Load<Zaposleni>(ob.Id.Zaposleni.OsobaId), // Ucitavam zaposlenog iz baze
                        Kategorija = ob.Id.Kategorija // Postavljam kategoriju
                    }
                };

                await session.SaveAsync(novaKategorija);
                await session.FlushAsync();
            }
            else
            {
                MessageBox.Show("Session or KategorijaBasic object is null.");
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
    public static async Task obrisiKategoriju(int id, string kategorija)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (s != null)
            {
                // Kreiram kompozitni kljuc
                KategorijaId kategorijaId = new KategorijaId
                {
                    Zaposleni = s.Load<Zaposleni>(id),
                    Kategorija = kategorija
                };

                Kategorije? o = await s.GetAsync<Kategorije>(kategorijaId);

                if (o != null)
                {
                    await s.DeleteAsync(o);
                    await s.FlushAsync();
                }
                else
                {
                    MessageBox.Show("Kategorija nije pronadjena.");
                }
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            s?.Close(); 
        }
    }

    #endregion

    #region Funkcije za prikupljanje podataka
    public static List<int> GetAllAdminIDsFromZaposleni() //f-ja za uzimanje svih admin ID-jeva iz tabele zaposleni da bih
    {                                                           //napunio combobox
        List<int> osobaID = new List<int>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                // Izvrsavam upit koji dohvatava sve jedinstvene ID-eve admin-a iz tabele Zaposleni
                var SviID = session.Query<Zaposleni>()
                                             .Where(bt => bt.TipZaposlenog == "Administrator")
                                             .Select(bt => bt.ID_Osobe)
                                             .Distinct()
                                             .ToList();

                osobaID.AddRange(SviID);
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

        return osobaID;
    }
    public static List<int> GetAllVozacIDsFromZaposleni() //f-ja za uzimanje svih vozac ID-jeva iz tabele zaposleni da bih
    {                                                           //napunio combobox
        List<int> osobaID = new List<int>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                // Izvrsavam upit koji dohvatava sve jedinstvene ID-eve vozaca iz tabele Zaposleni
                var SviID = session.Query<Zaposleni>()
                                             .Where(bt => bt.TipZaposlenog == "Vozac")
                                             .Select(bt => bt.ID_Osobe)
                                             .Distinct()
                                             .ToList();

                osobaID.AddRange(SviID);
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

        return osobaID;
    }
    public static List<int> GetAllMusterijaIDsFromMusterija() //f-ja za uzimanje musterija ID-jeva iz tabele zaposleni da bih
    {                                                           //napunio combobox
        List<int> osobaID = new List<int>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                // Izvrsavam upit koji dohvatava sve jedinstvene ID-eve musterija iz tabele Musterija
                var SviID = session.Query<Musterija>()
                                             .Select(bt => bt.ID_Osobe)
                                             .Distinct()
                                             .ToList();

                osobaID.AddRange(SviID);
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

        return osobaID;
    }
    public static List<BrojeviTelefonaId> GetAllTelefoniZaMusterije(int idmusterije) //f-ja za uzimanje svih brojeva telefona za odredjenu 
    {                                                           //musteriju kako bih napunio combobox
        List<BrojeviTelefonaId> brojeviTelefona = new List<BrojeviTelefonaId>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                // Izvrsavam upit koji dohvatava sve brojeve telefona za određenu musteriju
                var telefoni = session.Query<BrojeviTelefona>()
                                      .Where(bt => bt.BrojTelefona.Osoba.ID_Osobe == idmusterije)
                                      .Select(bt => bt.BrojTelefona)
                                      .Distinct()
                                      .ToList();

                brojeviTelefona.AddRange(telefoni);
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

        return brojeviTelefona;
    }
    public static List<int> GetAllVoziloIDsFromVozilo() //f-ja za uzimanje svih vozilo ID-jeva iz tabele Vozilo da bih
    {                                                           //napunio combobox
        List<int> voziloID = new List<int>();
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                // Izvrsavam upit koji dohvatava sve jedinstvene ID-eve vozila iz tabele Vozilo
                var SviID = session.Query<Vozilo>()
                                             .Select(bt => bt.ID_Vozila)
                                             .Distinct()
                                             .ToList();

                voziloID.AddRange(SviID);
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

        return voziloID;
    }

    #endregion

}