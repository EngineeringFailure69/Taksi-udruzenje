
namespace SBP_SLN4;

#region Voznja
public class VoznjaBasic
{
    public int VoznjaId { get; set; }
    public int MusterijaId { get; set; }
    public string Pocetna_Stanica { get; set; }
    public string Kranja_Stanica { get; set; }
    public string Br_Tel_Narucivanja { get; set; }
    public int AdminId { get; set; }
    public DateTime Vreme_Javljanja { get; set; }
    public string Br_Tel_Prim_Poziva { get; set; }
    public int VozacId { get; set; }
    public DateTime Vreme_Pocetka { get; set; }
    public DateTime? Vreme_Kraja { get; set; }

    public VoznjaBasic(int vid, int mid, string ps, string ks, string btn, int aid, DateTime vj, 
        string btpp, int idv, DateTime vp, DateTime? vk)
    {
        this.VoznjaId = vid;
        this.MusterijaId = mid;
        this.Pocetna_Stanica = ps;
        this.Kranja_Stanica = ks;
        this.Br_Tel_Narucivanja = btn;
        this.AdminId = aid;
        this.Vreme_Javljanja = vj;
        this.Br_Tel_Prim_Poziva = btpp;
        this.VozacId = idv;
        this.Vreme_Pocetka = vp;
        this.Vreme_Kraja = vk;
    }
    public VoznjaBasic()
    {
       
    }
}


public class VoznjaPregled
{
    public int VoznjaId { get; set; }
    public int AdministratorId { get; set; }
    public int VozacId  { get; set; }
    public int MusterijaId { get; set; }
    public string Pocetna_Stanica { get; set; }
    public string Kranja_Stanica { get; set; }
    public DateTime Vreme_Pocetka { get; set; }
    public DateTime? Vreme_Kraja { get; set; }
    public string Telefon_Narucivanja { get; set; }
    public string? ImeVozaca { get; set; }
    public string? ImeAdmin { get; set; }

    public VoznjaPregled(int vid, int aid, int vzid, int mid, string ps, string ks, DateTime vp, DateTime? vk, string telefon_Narucivanja, string? imeVozaca, string? imeAdmina)
    {
        this.VoznjaId = vid;
        this.AdministratorId = aid;
        this.VozacId = vzid;
        this.MusterijaId = mid;
        this.Pocetna_Stanica = ps;
        this.Kranja_Stanica = ks;
        this.Vreme_Pocetka = vp;
        this.Vreme_Kraja = vk;
        this.Telefon_Narucivanja = telefon_Narucivanja;
        this.ImeVozaca = imeVozaca;
        this.ImeAdmin = imeAdmina;
    }

    public VoznjaPregled()
    {
    }
   
}

#endregion

#region Osoba
public class OsobaPregled
{
    public int OsobaId { get; set; }
    public string ulica { get; set; }
    public string broj { get; set; }
    public string Tip_Osobe { get; set; }

    public OsobaPregled()
    {

    }
    public OsobaPregled(int oid, string ul, string br, string tip)
    {
        this.OsobaId = oid;
        this.ulica = ul;
        this.broj = br;
        this.Tip_Osobe = tip;
    }
}

public class OsobaBasic
{
    public int OsobaId { get; set; }
    public string ulica { get; set; }
    public string broj { get; set; }
    public string Tip_Osobe { get; set; }

    public OsobaBasic() { }
    public OsobaBasic(int oid, string ul, string br, string tip)
    {
        this.OsobaId = oid;
        this.ulica = ul;
        this.broj = br;
        this.Tip_Osobe = tip;
    }
}

#endregion

#region Zaposleni

public class ZaposleniPregled:OsobaPregled
{
    public string lime { get; set; }
    public string SrSlovo { get; set; }
    public string prezime { get; set; }
    public string jmbg { get; set; }
    public string Tip_Zaposlenog { get; set; }
    public string? Broj_Vozacke { get; set; }
    public string? Strucna_Sprema { get; set; }

    public ZaposleniPregled()
    {

    }
    public ZaposleniPregled(int oid, string ul, string br, string tip, 
        string li, string ss, string pr, string jmbg, string tz, string? bv, string? sts):base(oid, ul, br, tip)
    {
        this.lime = li;
        this.SrSlovo = ss;
        this.prezime = pr;
        this.jmbg = jmbg;
        this.Tip_Zaposlenog = tz;
        this.Broj_Vozacke = bv;
        this.Strucna_Sprema = sts;
    }
}

public class ZaposleniBasic:OsobaBasic
{
    public string lime { get; set; }
    public string SrSlovo { get; set; }
    public string prezime { get; set; }
    public string jmbg { get; set; }
    public string Tip_Zaposlenog { get; set; }
    public string? Broj_Vozacke { get; set; }
    public string? Strucna_Sprema { get; set; }

    public ZaposleniBasic() {  }
    public ZaposleniBasic(int oid, string ul, string br, string tip, 
        string li, string ss, string pr, string jmbg, string tz, string? bv, string? sts):base(oid, ul, br, tip)
    {
        this.lime = li;
        this.SrSlovo = ss;
        this.prezime = pr;
        this.jmbg = jmbg;
        this.Tip_Zaposlenog = tz;
        this.Broj_Vozacke = bv;
        this.Strucna_Sprema = sts;
    }
}
public class ZaposleniBasicBrojevi : OsobaBasic
{
    public string lime { get; set; }
    public string SrSlovo { get; set; }
    public string prezime { get; set; }
    public string jmbg { get; set; }
    public string Tip_Zaposlenog { get; set; }
    public string? Broj_Vozacke { get; set; }
    public string? Strucna_Sprema { get; set; }
    public string BrojTelefona { get; set; } //Broj telefona zaposlenog
    public ZaposleniBasicBrojevi() { }
    public ZaposleniBasicBrojevi(int oid, string ul, string br, string tip,
    string li, string ss, string pr, string jmbg, string tz, string? bv, string? sts, string brojeviTelefona) : base(oid, ul, br, tip)
    {
        this.lime = li;
        this.SrSlovo = ss;
        this.prezime = pr;
        this.jmbg = jmbg;
        this.Tip_Zaposlenog = tz;
        this.Broj_Vozacke = bv;
        this.Strucna_Sprema = sts;
        this.BrojTelefona = brojeviTelefona;
    }
}

#endregion

#region Musterija
public class MusterijaPregled:OsobaPregled
{
    public int Br_Koriscenih_Voznji { get; set; }
    public List<BrojeviTelefonaPregledMusterija>? BrojeviTelefona { get; set; }
    public MusterijaPregled() { }
    public MusterijaPregled(int oid, string ul, string br, string tip, int br_Koriscenih_Voznji, List<BrojeviTelefonaPregledMusterija>? brojeviTelefona) : base(oid, ul, br, tip)
    {
        this.Br_Koriscenih_Voznji = br_Koriscenih_Voznji;
        this.BrojeviTelefona = brojeviTelefona;
    }

}

public class MusterijaBasic:OsobaBasic
{
    public int Br_Koriscenih_Voznji { get; set; }
    public MusterijaBasic() { }
    public MusterijaBasic(int oid, string ul, string br, string tip, int br_Koriscenih_Voznji): base(oid, ul, br, tip)
    {
        this.Br_Koriscenih_Voznji = br_Koriscenih_Voznji;
    }
}

public class MusterijaBasicBrojevi : OsobaBasic
{
    public int Br_Koriscenih_Voznji { get; set; }
    public string BrojTelefona { get; set; } //Broj telefona musterije
    public MusterijaBasicBrojevi() { }
    public MusterijaBasicBrojevi(int oid, string ul, string br, string tip, int br_Koriscenih_Voznji, string brojeviTelefona)
        : base(oid, ul, br, tip)
    {
        this.Br_Koriscenih_Voznji = br_Koriscenih_Voznji;
        this.BrojTelefona = brojeviTelefona;
    }
}

#endregion

#region BrojeviTelefona
public class BrojeviTelefonaPregled
{
    public BrojeviTelefonaId Id;
    public BrojeviTelefonaPregled() { }
    public BrojeviTelefonaPregled(BrojeviTelefonaId id)
    {
        this.Id = id;
    }
        
}

public class BrojeviTelefonaPregledMusterija
{
    public string BrTel { get; set; }

    public BrojeviTelefonaPregledMusterija() { }

    public BrojeviTelefonaPregledMusterija(string brTel)
    {
        this.BrTel = brTel;
    }
}
public class BrojeviTelefonaBasic
{
    public BrojeviTelefonaIdBasic Id;
    public BrojeviTelefonaBasic() { }
    public BrojeviTelefonaBasic(BrojeviTelefonaIdBasic id)
    {
        this.Id = id;
    }

}
public class BrojeviTelefonaIdBasic
{
    public  OsobaBasic Osoba { get; set; }
    public string BrTel { get; set; }

    public BrojeviTelefonaIdBasic() { }
}

#endregion

#region Kategorija
public class KategorijePregled
{
    public KategorijaId Id;
    public KategorijePregled() { }
    public KategorijePregled(KategorijaId id)
    {
        Id = id;
    }
}
public class KategorijeBasic
{
    public KategorijaIdBasic Id;
    public KategorijeBasic() { }
    public KategorijeBasic(KategorijaIdBasic id)
    {
        this.Id = id;
    }
}
public class KategorijaIdBasic
{
    public ZaposleniBasic Zaposleni { get; set; }
    public string Kategorija { get; set; }
    public KategorijaIdBasic() { }
}
#endregion

#region Vozilo
public class VoziloPregled
{
    public int VoziloId { get; set; }
    public string marka { get; set; }
    public string tip { get; set; }
    public string? regOznaka { get; set; }
    public string? ImeVlasnika { get; set; }
    public string? boja { get; set; }
    public VoziloPregled() { }
    public VoziloPregled(int vid, string m, string t, string? reg, string? ime, string? b)
    {
            this.VoziloId = vid;
            this.marka = m;
            this.tip = t;
            this.regOznaka = reg;
            this.ImeVlasnika = ime;
            this.boja = b;
    }
}

public class VoziloBasic
{
    public int VoziloId { get; set; }
    public string marka { get; set; }
    public string tip { get; set; }
    public string? tipVozila { get; set; }
    public int? godinaProizvodnje { get; set; }
    public DateTime? DatIstekaReg { get; set; }
    public string? RegOznaka { get; set; }
    public int? VlasnikId { get; set; }
    public string? boja { get; set; }
    public VoziloBasic() { }
    public VoziloBasic(int vid, string mka, string tip, string? tipV, int? godiste, DateTime? dat, string? reg, int? idv, string? b)
    {
        this.VoziloId = vid;
        this.marka = mka;
        this.tip = tip;
        this.tipVozila = tipV;
        this.godinaProizvodnje = godiste;
        this.DatIstekaReg = dat;
        this.RegOznaka = reg;
        this.VlasnikId = idv;
        this.boja = b;
    }
}

#endregion

#region Upravlja
public class UpravljaPregled
{
    public int UpravljaId { get; set; }
    public int IdVozilo { get; set; }
    public int IdVozac { get; set; }
    public virtual string? RegOznaka { get; set; }
    public UpravljaPregled() { }
    public UpravljaPregled(int uid, int vid, int idv, string reg)
    {
        this.UpravljaId = uid;
        this.IdVozilo = vid;
        this.IdVozac = idv;
        this.RegOznaka = reg;
    }
}
public class UpravljaBasic
{
    public int UpravljaId { get; set; }
    public int IdVozilo { get; set; }
    public int IdVozac { get; set; }
    public virtual DateTime DatOd { get; set; }
    public virtual DateTime? DatDo { get; set; }
    public UpravljaBasic()
    {

    }
    public UpravljaBasic(int uid, int vid, int idv, DateTime dod, DateTime? ddo)
    {
        this.UpravljaId = uid;
        this.IdVozilo = vid;
        this.IdVozac = idv;
        this.DatOd = dod;
        this.DatDo = ddo;
    }
}
#endregion
