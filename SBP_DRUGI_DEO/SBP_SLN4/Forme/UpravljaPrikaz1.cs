namespace SBP_SLN4.Forme
{
    public partial class UpravljaPrikaz1 : Form
    {
        public UpravljaBasic? upravljaBasic;
        public UpravljaPrikaz1()
        {
            InitializeComponent();
        }

        private void UpravljaPrikaz_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void PopulateInfos() //funkcija za upis podataka u grid
        {
            dgwPrikaz.Rows.Clear();
            dgwPrikaz.Columns.Clear();

            dgwPrikaz.Columns.Add("UpravljaId", "Upravlja ID");
            dgwPrikaz.Columns.Add("IdVozilo", "ID Vozilo");
            dgwPrikaz.Columns.Add("IdVozac", "ID Vozač");
            dgwPrikaz.Columns.Add("RegOznaka", "Registraciona Oznaka");

            List<UpravljaPregled> uprInfos = DTOManager.GetUprInfos();

            foreach (UpravljaPregled op in uprInfos)
            {
                dgwPrikaz.Rows.Add(
                [
                    op.UpravljaId.ToString(),
                    op.IdVozilo.ToString(),
                    op.IdVozac.ToString(),
                    op.RegOznaka ?? ""
                ]);
            }

            dgwPrikaz.Refresh();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {

        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {

        }
    }
}