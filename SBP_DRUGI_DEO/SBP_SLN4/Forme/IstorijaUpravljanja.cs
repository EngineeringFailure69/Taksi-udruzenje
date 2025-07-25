namespace SBP_SLN4.Forme
{
    public partial class IstorijaUpravljanja : Form
    {
        public List<UpravljaPregled> upravljaPregled;
        public IstorijaUpravljanja()
        {
            InitializeComponent();
        }
        public IstorijaUpravljanja(List<UpravljaPregled> u) : this()
        {
            upravljaPregled = u;
            popuniPodacima();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IstorijaUpravljanja_Load(object sender, EventArgs e)
        {

        }
        public void popuniPodacima()
        {
            if (upravljaPregled != null)
            {
                lwPrikaz.Items.Clear();
                lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
                lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
                lwPrikaz.GridLines = true;

                lwPrikaz.Columns.Clear();
                lwPrikaz.Columns.Add("ID");
                lwPrikaz.Columns.Add("IdVozilo", 150);
                lwPrikaz.Columns.Add("IdVozac", 150);
                lwPrikaz.Columns.Add("Reg Oznaka", 100);

                foreach (UpravljaPregled u in upravljaPregled)
                {
                    ListViewItem item = new ListViewItem(new string[] { u.UpravljaId.ToString(), u.IdVozilo.ToString(), u.IdVozac.ToString(), u.RegOznaka });
                    lwPrikaz.Items.Add(item);
                }

                lwPrikaz.Refresh();
            }
        }
    }
}
