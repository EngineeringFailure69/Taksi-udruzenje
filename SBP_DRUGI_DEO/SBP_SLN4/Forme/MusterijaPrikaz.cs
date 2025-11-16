namespace SBP_SLN4.Forme
{
    public partial class MusterijaPrikaz : Form
    {
        public MusterijaPrikaz()
        {
            InitializeComponent();
        }

        private void MusterijaPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            lwPrikaz.Items.Clear();
            lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
            lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
            lwPrikaz.GridLines = true;

            List<MusterijaPregled> podaci = DTOManager.GetMusterijaInfos();

            int maxBrojeviTelefona = podaci.Max(m => m.BrojeviTelefona?.Count ?? 0);

            lwPrikaz.Columns.Add("ID Osobe", 100);
            lwPrikaz.Columns.Add("Ulica", 100);
            lwPrikaz.Columns.Add("Broj", 90);
            lwPrikaz.Columns.Add("Br_kor_voznji", 100);

            for (int i = 0; i < maxBrojeviTelefona; i++)
            {
                lwPrikaz.Columns.Add($"Broj telefona {i + 1}", 120);
            }

            foreach (MusterijaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.OsobaId.ToString(), m.ulica, m.broj, m.Br_Koriscenih_Voznji.ToString() });

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

        private async void btnIzmeniMusteriju_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}