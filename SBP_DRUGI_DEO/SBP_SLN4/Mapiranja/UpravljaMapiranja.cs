
namespace SBP_SLN4.Mapiranja;

class UpravljaMapiranja:ClassMap<Upravlja>
{
    public UpravljaMapiranja() 
    {
        Table("UPRAVLJA");

        Id(x => x.ID_Upravljanja, "ID_UPRAVLJANJA").GeneratedBy.TriggerIdentity();

        Map(x => x.DatumOd, "DATUM_OD");
        Map(x => x.DatumDo, "DATUM_DO");

        References(x => x.ZaposleniVozac).Column("VOZACID").LazyLoad();
        References(x => x.Vozilo).Column("VOZILOID").LazyLoad();
    }
}
