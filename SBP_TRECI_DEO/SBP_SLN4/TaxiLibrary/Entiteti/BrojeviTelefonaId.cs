namespace TaxiLibrary.Entiteti;
internal class BrojeviTelefonaId
{
    internal protected virtual required Osoba Osoba { get; set; }
    internal protected virtual required string BrojTelefona { get; set; }
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj?.GetType() != typeof(BrojeviTelefonaId))
        {
            return false;
        }

        BrojeviTelefonaId compare = (BrojeviTelefonaId)obj;

        return Osoba.ID_Osobe == compare.Osoba.ID_Osobe &&
               BrojTelefona == compare.BrojTelefona;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}