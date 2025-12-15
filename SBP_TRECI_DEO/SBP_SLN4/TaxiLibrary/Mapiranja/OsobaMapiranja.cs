namespace TaxiLibrary.Mapiranja;
internal class OsobaMapiranja:ClassMap<Osoba>
{
    public OsobaMapiranja() 
    {
        Table("OSOBA");

        Id(x => x.ID_Osobe, "ID_OSOBE").GeneratedBy.TriggerIdentity();

        Map(x => x.Ulica, "ULICA");
        Map(x => x.Broj, "BROJ");
        Map(x => x.TipOsobe, "TIP_OSOBE");

        HasMany(x => x.BrojeviTelefona).KeyColumn("ID_OSOBE").LazyLoad().Cascade.All().Inverse();
    }
}