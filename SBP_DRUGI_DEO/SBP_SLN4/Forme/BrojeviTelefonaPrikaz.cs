namespace SBP_SLN4.Forme
{
    public partial class BrojeviTelefonaPrikaz : Form
    {
        public BrojeviTelefonaPrikaz()
        {
            InitializeComponent();
        }

        private void BrojeviTelefonaPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            lwPrikaz.Items.Clear();
            lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
            lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
            lwPrikaz.GridLines = true;
            List<BrojeviTelefonaPregled> podaci = DTOManager.GetBrojInfos();

            var firstItem = podaci[0];
            lwPrikaz.Columns.Add("ID Osobe", 100);
            lwPrikaz.Columns.Add("Broj telefona", 130);

            foreach (BrojeviTelefonaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Id.Osoba.ID_Osobe.ToString(), m.Id.BrojTelefona });
                lwPrikaz.Items.Add(item);
            }
            lwPrikaz.Refresh();
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajBrojTelefona dodajBrojForm = new DodajBrojTelefona();
            dodajBrojForm.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            
        }
    }
}
