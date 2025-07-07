namespace SBP_SLN4.Entiteti;

public class Osoba
{
    public virtual int ID_Osobe { get; set; }
    public required virtual string Ulica { get; set; }
    public required virtual string Broj { get; set; }
    public required virtual string TipOsobe { get; set; }
    public virtual IList<BrojeviTelefona>? BrojeviTelefona { get; set; } = [];
}
