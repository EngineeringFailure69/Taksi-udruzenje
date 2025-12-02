namespace TaxiLibrary.DTOs;

public class ZaposleniView : OsobaView
{
    public string lime { get; set; }
    public string SrSlovo { get; set; }
    public string prezime { get; set; }
    public string jmbg { get; set; }
    public string Tip_Zaposlenog { get; set; }
    public string? Broj_Vozacke { get; set; }
    public string? Strucna_Sprema { get; set; }
    public string BrojTelefona { get; set; } //Broj telefona zaposlenog

    public ZaposleniView() { }

    internal ZaposleniView(int oid, string ul, string br, string li, string ss, string pr, string jmbg, string tz,
        string? bv, string? sts, string brojeviTelefona) : base(oid, ul, br, "Zaposleni")
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