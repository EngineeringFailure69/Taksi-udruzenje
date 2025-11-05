namespace SBP_SLN4.Forme
{
    public partial class OsobaPrikaz : Form
    {
        public OsobaPrikaz()
        {
            InitializeComponent();
        }

        private void btnPrikaziMusterije_Click(object sender, EventArgs e)
        {
            MusterijaPrikaz musterijaForm = new MusterijaPrikaz();
            musterijaForm.ShowDialog();
        }

        private void OsobaPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnPrikaziZaposlene_Click(object sender, EventArgs e)
        {
            ZaposleniPrikaz prikazForm = new ZaposleniPrikaz();
            prikazForm.ShowDialog();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposleni zapForm = new DodajZaposleni();
            zapForm.ShowDialog();
        }

        private void btnDodajMusteriju_Click(object sender, EventArgs e)
        {
            DodajMusteriju mustForm = new DodajMusteriju();
            mustForm.ShowDialog();
        }

        public void popuniPodacima()
        {
            lwPrikaz.Items.Clear();
            lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
            lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
            lwPrikaz.GridLines = true;
            List<OsobaPregled> podaci = DTOManager.GetOsobaInfos();

            var firstItem = podaci[0];
            lwPrikaz.Columns.Add("ID Osobe", 100);
            lwPrikaz.Columns.Add("Ulica", 130);
            lwPrikaz.Columns.Add("Broj", 120);
            lwPrikaz.Columns.Add("Tip osobe", 100);

            foreach (OsobaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.OsobaId.ToString(), m.ulica, m.broj, m.Tip_Osobe });
                lwPrikaz.Items.Add(item);
            }
            lwPrikaz.Refresh();
        }

        private void btnPrikazImenik_Click(object sender, EventArgs e)
        {
            BrojeviTelefonaPrikaz telForm = new BrojeviTelefonaPrikaz();
            telForm.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            KategorijePrikaz kategorijeForm = new KategorijePrikaz();
            kategorijeForm.ShowDialog();
        }
    }
}
