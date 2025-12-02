namespace TaxiLibrary.DTOs;

public class VoziloView
{
    public int VoziloId { get; set; }
    public string marka { get; set; }
    public string tip { get; set; }
    public string? tipVozila { get; set; }
    public int? godinaProizvodnje { get; set; }
    public DateTime? DatIstekaReg { get; set; }
    public string? RegOznaka { get; set; }
    public int? VlasnikId { get; set; }
    public string? ImeVlasnika { get; set; }
    public string? boja { get; set; }
    public VoziloView() { }
    internal VoziloView(int vid, string mka, string tip, string? tipV, int? godiste, DateTime? dat, string? reg, int? idv, string? ime, string? b) : this()
    {
        this.VoziloId = vid;
        this.marka = mka;
        this.tip = tip;
        this.tipVozila = tipV;
        this.godinaProizvodnje = godiste;
        this.DatIstekaReg = dat;
        this.RegOznaka = reg;
        this.VlasnikId = idv;
        this.ImeVlasnika = ime;
        this.boja = b;
    }
    internal VoziloView(int vid, string mka, string tip, string? tipV, int? godiste, DateTime? dat, string? reg, int? idv, string? b) : this()
    {
        this.VoziloId = vid;
        this.marka = mka;
        this.tip = tip;
        this.tipVozila = tipV;
        this.godinaProizvodnje = godiste;
        this.DatIstekaReg = dat;
        this.RegOznaka = reg;
        this.VlasnikId = idv;
        this.boja = b;
    }
}