namespace TaxiLibrary.Entiteti;
internal class Vozilo
{
    internal protected virtual int ID_Vozila { get; set; }
    internal protected required virtual string Marka { get; set; }
    internal protected required virtual string Tip { get; set; }
    internal protected virtual string? TipVozila { get; set; }
    internal protected virtual int? GodinaProizvodnje { get; set; }
    internal protected virtual DateTime? DatumIstekaRegistracije { get; set; }
    internal protected virtual string? RegistarskaOznaka { get; set; }
    internal protected virtual string? Boja { get; set; }
    internal protected virtual Zaposleni? Zaposleni { get; set; }
    internal protected virtual IList<Upravlja>? UpravljaVozilom { get; set; } = [];
}