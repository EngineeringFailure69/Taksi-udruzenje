namespace TaxiLibrary.DTOs;

public class BrojeviTelefonaView
{
    public BrojeviTelefonaIdView Id { get; set; }
    public BrojeviTelefonaView() { }
    internal BrojeviTelefonaView(BrojeviTelefonaIdView id) : this()
    {
        this.Id = id;
    }
}