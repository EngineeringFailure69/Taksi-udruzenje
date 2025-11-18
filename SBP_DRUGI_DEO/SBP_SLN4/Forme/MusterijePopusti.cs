namespace SBP_SLN4.Forme
{
    public partial class MusterijePopusti : Form
    {
        public List<MusterijaPregled> popustPregled;
        public MusterijePopusti()
        {
            InitializeComponent();
        }

        public MusterijePopusti(List<MusterijaPregled> u) : this()
        {
            popustPregled = u;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            if (popustPregled != null)
            {
                int popust = 0;
                lwPrikaz.Items.Clear();
                lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
                lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
                lwPrikaz.GridLines = true;

                lwPrikaz.Columns.Clear();
                int maxBrojeviTelefona = popustPregled.Max(m => m.BrojeviTelefona?.Count ?? 0);

                lwPrikaz.Columns.Add("ID Osobe", 100);
                lwPrikaz.Columns.Add("Ulica", 100);
                lwPrikaz.Columns.Add("Broj", 90);
                lwPrikaz.Columns.Add("Br_kor_voznji", 100);
                lwPrikaz.Columns.Add("Popust u %", 90);

                for (int i = 0; i < maxBrojeviTelefona; i++)
                {
                    lwPrikaz.Columns.Add($"Broj telefona {i + 1}", 120);
                }

                foreach (MusterijaPregled m in popustPregled)
                {
                    if (m.Br_Koriscenih_Voznji >= 10)
                    {
                        popust = 0;
                        popust += m.Br_Koriscenih_Voznji - (m.Br_Koriscenih_Voznji % 10);
                    }
                    if (m.Br_Koriscenih_Voznji >= 15)
                    {
                        popust = 0;
                        popust += m.Br_Koriscenih_Voznji - (m.Br_Koriscenih_Voznji % 15);
                    }
                    if (m.Br_Koriscenih_Voznji >= 20)
                    {
                        popust = 0;
                        popust += m.Br_Koriscenih_Voznji - (m.Br_Koriscenih_Voznji % 20);
                    }

                    ListViewItem item = new ListViewItem(new string[] { m.OsobaId.ToString(), m.ulica, m.broj, m.Br_Koriscenih_Voznji.ToString() });
                    item.SubItems.Add(popust.ToString());

                    if (m.BrojeviTelefona != null)
                    {
                        foreach (var broj in m.BrojeviTelefona)
                        {
                            item.SubItems.Add(broj.BrTel);
                        }
                    }

                    for (int i = m.BrojeviTelefona?.Count ?? 0; i < maxBrojeviTelefona; i++)
                    {
                        item.SubItems.Add(string.Empty);
                    }

                    lwPrikaz.Items.Add(item);
                }

                lwPrikaz.Refresh();
            }
        }

        private void MusterijePopusti_Load(object sender, EventArgs e)
        {

        }
    }
}