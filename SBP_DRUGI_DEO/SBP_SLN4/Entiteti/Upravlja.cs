
namespace SBP_SLN4.Entiteti;

public class Upravlja
{
    public virtual int ID_Upravljanja { get; set; }
    public required virtual DateTime DatumOd { get; set; }
    public virtual DateTime? DatumDo { get; set; }
    public required virtual Zaposleni ZaposleniVozac { get; set; }
    public required virtual Vozilo Vozilo { get; set; }
}
