
namespace SBP_SLN4.Mapiranja;

class MusterijaMapiranja:SubclassMap<Musterija>
{
    public MusterijaMapiranja() 
    {
        Table("MUSTERIJA");

        KeyColumn("ID_OSOBE");

        Map(x => x.BrKoriscenihVoznji, "BROJ_KORISCENIH_VOZNJI");
    }
}
