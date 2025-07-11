
namespace SBP_SLN4.Mapiranja;

class ZaposleniMapiranja:SubclassMap<Zaposleni>
{
    public ZaposleniMapiranja() 
    {
        Table("ZAPOSLENI");

        KeyColumn("ID_OSOBE");

        Map(x => x.Lime, "LIME");
        Map(x => x.SrednjeSlovo, "SREDNJE_SLOVO");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.JMBG, "JMBG");
        Map(x => x.TipZaposlenog, "TIP_ZAPOSLENOG");
        Map(x => x.BrojVozacke, "BROJ_VOZACKE");
        Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");
    }
}
