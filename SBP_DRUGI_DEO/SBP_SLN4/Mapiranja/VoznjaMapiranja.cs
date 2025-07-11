
namespace SBP_SLN4.Mapiranja;

class VoznjaMapiranja:ClassMap<Voznja>
{
    public VoznjaMapiranja() 
    {
        Table("VOZNJA");

        Id(x => x.ID_Voznje, "ID_VOZNJE").GeneratedBy.TriggerIdentity();

        Map(x => x.PocetnaStanica, "POCETNA_STANICA");
        Map(x => x.KrajnjaStanica, "KRAJNJA_STANICA");
        Map(x => x.BrTelNarucivanja, "BR_TEL_NARUCIVANJA");
        Map(x => x.VremeJavljanja, "VREME_JAVLJANJA");
        Map(x => x.BrTelPrimljenogPoziva, "BR_TEL_PRIMLJENOG_POZIVA");
        Map(x => x.VremePocetka, "VREME_POCETKA");
        Map(x => x.VremeKraja, "VREME_KRAJA");

        References(x => x.Musterija).Column("MUSTERIJAID").LazyLoad();
        References(x => x.ZaposleniVozac).Column("VOZACID").LazyLoad();
        References(x => x.ZaposleniAdmin).Column("ADMINISTRATORID").LazyLoad();
    }
}
