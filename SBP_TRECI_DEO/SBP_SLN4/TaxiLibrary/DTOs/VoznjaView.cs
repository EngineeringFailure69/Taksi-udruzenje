namespace TaxiLibrary.DTOs;

public class VoznjaView
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

    internal VoznjaView(Voznja? v):this()
    {
        this.VoznjaId = v.ID_Voznje;
        this.MusterijaId = v.Musterija.ID_Osobe;
        this.Pocetna_Stanica = v.PocetnaStanica;
        this.Kranja_Stanica = v.KrajnjaStanica;
        this.Br_Tel_Narucivanja = v.BrTelNarucivanja;
        this.AdminId = v.ZaposleniAdmin.ID_Osobe;
        this.Vreme_Javljanja = v.VremeJavljanja;
        this.Br_Tel_Prim_Poziva = v.BrTelPrimljenogPoziva;
        this.VozacId = v.ZaposleniVozac.ID_Osobe;
        this.Vreme_Pocetka = v.VremePocetka;
        this.Vreme_Kraja = v.VremeKraja;
    }
    public VoznjaView()
    {

    }
}