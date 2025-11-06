namespace SBP_SLN4.Forme
{
    public partial class ZaposleniPrikaz : Form
    {
        public ZaposleniPrikaz()
        {
            InitializeComponent();
        }

        private void ZaposleniPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            lwPrikaz.Items.Clear();
            lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
            lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
            lwPrikaz.GridLines = true;
            List<ZaposleniPregled> podaci = DTOManager.GetZaposleniInfos();

            var firstItem = podaci[0];
            lwPrikaz.Columns.Add("ID Osobe", 100);
            lwPrikaz.Columns.Add("Licno ime", 100);
            lwPrikaz.Columns.Add("Srednje slovo", 120);
            lwPrikaz.Columns.Add("Prezime", 100);
            lwPrikaz.Columns.Add("JMBG", 120);
            lwPrikaz.Columns.Add("Tip zaposlenog", 120);
            lwPrikaz.Columns.Add("Broj vozacke", 200);
            lwPrikaz.Columns.Add("Strucna sprema", 200);

            foreach (ZaposleniPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { z.OsobaId.ToString(), z.lime, z.SrSlovo, z.prezime, z.jmbg,
                z.Tip_Zaposlenog, z.Broj_Vozacke, z.Strucna_Sprema});
                lwPrikaz.Items.Add(item);

            }

            lwPrikaz.Refresh();
        }

        private async void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (lwPrikaz.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog cije podatke zelite da izmenite!");
                return;
            }

            string? id = lwPrikaz.SelectedItems[0].SubItems[0].Text;

            if (int.TryParse(id, out int zId))
            {
                ZaposleniBasic ob = await DTOManager.GetZaposleniBasic(zId);

                IzmeniZaposlenog edbForm = new(ob);

                if (edbForm.ShowDialog() == DialogResult.OK)
                {
                    await DTOManager.UpdateZaposleniBasic(edbForm.zaposleni);
                    popuniPodacima();
                }
            }
        }
    }
}