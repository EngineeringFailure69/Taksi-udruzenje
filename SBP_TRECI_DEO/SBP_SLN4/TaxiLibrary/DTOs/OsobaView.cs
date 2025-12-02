namespace TaxiLibrary.DTOs;

public class OsobaView
{
    public int OsobaId { get; set; }
    public string ulica { get; set; }
    public string broj { get; set; }
    public string Tip_Osobe { get; set; }

    public OsobaView() { }
    internal OsobaView(int oid, string ul, string br, string tip):this()
    {
        this.OsobaId = oid;
        this.ulica = ul;
        this.broj = br;
        this.Tip_Osobe = tip;
    }
}