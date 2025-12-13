namespace TaxiLibrary.Entiteti;
internal class Zaposleni : Osoba
{
    internal protected required virtual string Lime { get; set; }
    internal protected required virtual string SrednjeSlovo { get; set; }
    internal protected required virtual string Prezime { get; set; }
    internal protected required virtual string JMBG { get; set; }
    internal protected required virtual string TipZaposlenog { get; set; }
    internal protected virtual string? BrojVozacke { get; set; }
    internal protected virtual string? StrucnaSprema { get; set; }
}