namespace TaxiLibrary.DTOs;

public class KategorijaView
{
    public KategorijaIdView Id { get; set; }
    public KategorijaView() { }
    internal KategorijaView(KategorijaIdView id):this()
    {
        this.Id = id;
    }
}