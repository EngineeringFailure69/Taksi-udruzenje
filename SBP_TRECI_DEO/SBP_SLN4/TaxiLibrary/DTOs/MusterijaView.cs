namespace TaxiLibrary.DTOs;

public class MusterijaView:OsobaView
{
    public int Br_Koriscenih_Voznji { get; set; }
    public string BrojTelefona { get; set; } //Broj telefona musterija
    public MusterijaView() { }
    internal MusterijaView(int oid, string ul, string br, string tip, int br_Koriscenih_Voznji, string brtel) : base(oid, ul, br, "Musterija")
    {
        this.Br_Koriscenih_Voznji = br_Koriscenih_Voznji;
        this.BrojTelefona = brtel;
    }
    internal MusterijaView(int oid, string ul, string br, string tip, int br_Koriscenih_Voznji) :base(oid, ul, br, "Musterija")
    {
        Br_Koriscenih_Voznji = br_Koriscenih_Voznji;
    }
    internal MusterijaView(string brojTelefona)
    {
        BrojTelefona = brojTelefona;
    }
}