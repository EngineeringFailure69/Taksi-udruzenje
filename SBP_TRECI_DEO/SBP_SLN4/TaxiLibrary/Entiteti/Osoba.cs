namespace TaxiLibrary.Entiteti;

internal class Osoba
{
    internal protected virtual int ID_Osobe { get; set; }
    internal protected required virtual string Ulica { get; set; }
    internal protected required virtual string Broj { get; set; }
    internal protected required virtual string TipOsobe { get; set; }
    internal protected virtual IList<BrojeviTelefona>? BrojeviTelefona { get; set; } = [];
}
