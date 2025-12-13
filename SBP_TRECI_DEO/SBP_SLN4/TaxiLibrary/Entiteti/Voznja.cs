namespace TaxiLibrary.Entiteti;
internal class Voznja
{
    internal protected virtual int ID_Voznje { get; set; }
    internal protected required virtual string PocetnaStanica { get; set; }
    internal protected required virtual string KrajnjaStanica { get; set; }
    internal protected required virtual string BrTelNarucivanja { get; set; }
    internal protected required virtual DateTime VremeJavljanja { get; set; }
    internal protected required virtual string BrTelPrimljenogPoziva { get; set; }
    internal protected required virtual DateTime VremePocetka { get; set; }
    internal protected virtual DateTime? VremeKraja { get; set; }
    internal protected required virtual Musterija Musterija { get; set; }
    internal protected required virtual Zaposleni ZaposleniVozac { get; set; }
    internal protected required virtual Zaposleni ZaposleniAdmin { get; set; }
}