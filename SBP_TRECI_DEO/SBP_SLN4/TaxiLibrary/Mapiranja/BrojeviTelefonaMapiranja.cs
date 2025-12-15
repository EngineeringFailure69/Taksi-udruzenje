namespace TaxiLibrary.Mapiranja;
internal class BrojeviTelefonaMapiranja:ClassMap<BrojeviTelefona>
{
    public BrojeviTelefonaMapiranja() 
    {
        Table("BROJEVI_TELEFONA");

        CompositeId(p=>p.BrojTelefona)
            .KeyProperty(x => x.BrojTelefona, "BROJ_TELEFONA")
            .KeyReference(x => x.Osoba, "ID_OSOBE");        
    }
}