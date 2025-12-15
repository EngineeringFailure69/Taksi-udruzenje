namespace TaxiLibrary.Mapiranja;
internal class VoziloMapiranja:ClassMap<Vozilo>
{
    public VoziloMapiranja() 
    {
        Table("VOZILO");

        Id(x => x.ID_Vozila, "ID_VOZILA").GeneratedBy.TriggerIdentity();

        Map(x => x.Marka, "MARKA");
        Map(x => x.Tip, "TIP");
        Map(x => x.TipVozila, "TIP_VOZILA");
        Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");
        Map(x => x.DatumIstekaRegistracije, "DATUM_ISTEKA_REGISTRACIJE");
        Map(x => x.RegistarskaOznaka, "REGISTARSKA_OZNAKA");
        Map(x => x.Boja, "BOJA");

        References(x => x.Zaposleni).Column("VLASNIKID").LazyLoad();

        HasMany(x => x.UpravljaVozilom).KeyColumn("VOZILOID").LazyLoad().Cascade.All().Inverse();
    }
}