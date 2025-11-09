namespace SBP_SLN4.Forme
{
    public partial class KategorijePrikaz : Form
    {
        public KategorijePrikaz()
        {
            InitializeComponent();
        }

        private void KategorijePrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            lwPrikaz.Items.Clear();
            lwPrikaz.View = View.Details; // Koristimo detaljan prikaz
            lwPrikaz.FullRowSelect = true; // Selektovanje cele redove
            lwPrikaz.GridLines = true;
            List<KategorijePregled> podaci = DTOManager.GetKategorijeInfos();

            var firstItem = podaci[0];
            lwPrikaz.Columns.Add("ID vozaca", 100);
            lwPrikaz.Columns.Add("Kategorija", 130);

            foreach (KategorijePregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Id.Zaposleni.ID_Osobe.ToString(), m.Id.Kategorija });
                lwPrikaz.Items.Add(item);
            }
            lwPrikaz.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KategorijaDodaj dodajForm = new KategorijaDodaj();
            dodajForm.ShowDialog();
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lwPrikaz.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kategoriju koju zelite da obrisete!");
                return;
            }

            int idvozaca = Int32.Parse(lwPrikaz.SelectedItems[0].SubItems[0].Text);
            string kategorija = lwPrikaz.SelectedItems[0].SubItems[1].Text;
            string poruka = "Da li zelite da obrisete izabranu kategoriju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiKategoriju(idvozaca, kategorija);
                MessageBox.Show("Brisanje kategorije je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}