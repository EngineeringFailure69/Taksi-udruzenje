
namespace SBP_SLN4.Entiteti;

public class Zaposleni : Osoba
{
    public required virtual string Lime { get; set; }
    public required virtual string SrednjeSlovo { get; set; }
    public required virtual string Prezime { get; set; }
    public required virtual string JMBG { get; set; }
    public required virtual string TipZaposlenog { get; set; }
    public virtual string? BrojVozacke { get; set; }
    public virtual string? StrucnaSprema { get; set; }
}
