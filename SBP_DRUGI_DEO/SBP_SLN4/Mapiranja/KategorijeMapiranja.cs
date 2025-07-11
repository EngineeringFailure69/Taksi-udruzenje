
namespace SBP_SLN4.Mapiranja;

class KategorijeMapiranja:ClassMap<Kategorije>
{
    public KategorijeMapiranja() 
    {
        Table("KATEGORIJE");

        CompositeId(p => p.Kategorija)
            .KeyProperty(x => x.Kategorija, "KATEGORIJA")
            .KeyReference(x => x.Zaposleni, "ID_VOZACA"); 
    }
}
