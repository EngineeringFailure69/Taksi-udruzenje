namespace TaxiLibrary.Entiteti;
internal class Upravlja
{
    internal protected virtual int ID_Upravljanja { get; set; }
    internal protected required virtual DateTime DatumOd { get; set; }
    internal protected virtual DateTime? DatumDo { get; set; }
    internal protected required virtual Zaposleni ZaposleniVozac { get; set; }
    internal protected required virtual Vozilo Vozilo { get; set; }
}