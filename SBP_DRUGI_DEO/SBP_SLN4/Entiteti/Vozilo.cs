
namespace SBP_SLN4.Entiteti;

public class Vozilo
{
    public virtual int ID_Vozila { get; set; }
    public required virtual string Marka { get; set; }
    public required virtual string Tip { get; set; }
    public virtual string? TipVozila { get; set; }
    public virtual int? GodinaProizvodnje { get; set; }
    public virtual DateTime? DatumIstekaRegistracije { get; set; }
    public virtual string? RegistarskaOznaka { get; set; }
    public virtual string? Boja { get; set; }
    public virtual Zaposleni? Zaposleni { get; set; }
    public virtual IList<Upravlja>? UpravljaVozilom { get; set; } = [];
    
}
