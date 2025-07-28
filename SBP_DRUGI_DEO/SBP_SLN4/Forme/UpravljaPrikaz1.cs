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
            dgwPrikaz.Columns.Add("IdVozac", "ID Vozac");
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
            DodajUpravlja dodajForm = new DodajUpravlja();
            dodajForm.ShowDialog();
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {

            if (dgwPrikaz.SelectedCells.Count == 0)
            {
                MessageBox.Show("Odaberite upravljanje!");
                return;
            }

            if (dgwPrikaz.SelectedCells.Count > 0)
            {
                string? id = dgwPrikaz.SelectedCells[0].Value.ToString();

                if (int.TryParse(id, out int uprId))
                {
                    UpravljaBasic ob = await DTOManager.GetUpravljaBasic(uprId);

                    IzmeniUpravlja edbForm = new(ob);

                    if (edbForm.ShowDialog() == DialogResult.OK)
                    {
                        await DTOManager.UpdateUpravljaBasic(edbForm.upravljaBasic);
                        edbForm.PopulateData();
                    }
                }
            }
        }
    }
}
