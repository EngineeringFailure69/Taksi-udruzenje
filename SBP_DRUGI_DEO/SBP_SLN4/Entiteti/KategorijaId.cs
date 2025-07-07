
namespace SBP_SLN4.Entiteti;
public class KategorijaId
{
    public virtual required Zaposleni Zaposleni { get; set; }
    public virtual required string Kategorija { get; set; }
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj?.GetType() != typeof(KategorijaId))
        {
            return false;
        }

        KategorijaId compare = (KategorijaId)obj;

        return Zaposleni.ID_Osobe == compare.Zaposleni.ID_Osobe &&
               Kategorija == compare.Kategorija;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
