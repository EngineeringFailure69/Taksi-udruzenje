
namespace SBP_SLN4.Entiteti;

public class Voznja
{
    public virtual int ID_Voznje { get; set; }
    public required virtual string PocetnaStanica { get; set; }
    public required virtual string KrajnjaStanica { get; set; }
    public required virtual string BrTelNarucivanja { get; set; }
    public required virtual DateTime VremeJavljanja { get; set; }
    public required virtual string BrTelPrimljenogPoziva { get; set; }
    public required virtual DateTime VremePocetka { get; set; }
    public virtual DateTime? VremeKraja { get; set; }
    public required virtual Musterija Musterija { get; set; }
    public required virtual Zaposleni ZaposleniVozac { get; set; }
    public required virtual Zaposleni ZaposleniAdmin { get; set; }
}
