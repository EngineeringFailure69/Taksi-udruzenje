namespace TaxiLibrary.DTOs;

public class UpravljaView
{
    public int UpravljaId { get; set; }
    public int IdVozilo { get; set; }
    public int IdVozac { get; set; }
    public virtual DateTime DatOd { get; set; }
    public virtual DateTime? DatDo { get; set; }
    public virtual string? RegOznaka { get; set; }
    public UpravljaView(){ }
    internal UpravljaView(int uid, int vid, int idv, DateTime dod, DateTime? ddo):this()
    {
        this.UpravljaId = uid;
        this.IdVozilo = vid;
        this.IdVozac = idv;
        this.DatOd = dod;
        this.DatDo = ddo;
    }
    internal UpravljaView(int uid, int vid, int idv, string reg, DateTime dod, DateTime? ddo) : this()
    {
        this.UpravljaId = uid;
        this.IdVozilo = vid;
        this.IdVozac = idv;
        this.RegOznaka = reg;
        this.DatOd = dod;
        this.DatDo = ddo;
    }
}