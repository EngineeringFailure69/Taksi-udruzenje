namespace SBP_SLN4.Forme
{
    public partial class VoznjaPrikaz : Form
    {
        public VoznjaPrikaz()
        {
            InitializeComponent();
        }
        private void VoznjaPrikazcs_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            lwVoznjaPrikaz.Items.Clear();
            lwVoznjaPrikaz.View = View.Details; 
            lwVoznjaPrikaz.FullRowSelect = true; 
            lwVoznjaPrikaz.GridLines = true;
            List<VoznjaPregled> podaci = DTOManager.GetVoznjaInfos();

            var firstItem = podaci[0];
            lwVoznjaPrikaz.Columns.Add("ID Voznje", 100);
            lwVoznjaPrikaz.Columns.Add("Admin ID", 100);
            lwVoznjaPrikaz.Columns.Add("Ime Admin-a", 120);
            lwVoznjaPrikaz.Columns.Add("Vozac ID", 100);
            lwVoznjaPrikaz.Columns.Add("Ime Vozaca", 120);
            lwVoznjaPrikaz.Columns.Add("Musterija ID", 100);
            lwVoznjaPrikaz.Columns.Add("Pocetna Stanica", 200);
            lwVoznjaPrikaz.Columns.Add("Kranja Stanica", 200);
            lwVoznjaPrikaz.Columns.Add("Vreme Pocetka", 200);
            lwVoznjaPrikaz.Columns.Add("Vreme Kraja", 200);
            lwVoznjaPrikaz.Columns.Add("Telefon Narucivanja", 180);

            foreach (VoznjaPregled v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { v.VoznjaId.ToString(), v.AdministratorId.ToString(), v.ImeAdmin,
                    v.VozacId.ToString(), v.ImeVozaca, v.MusterijaId.ToString(), v.Pocetna_Stanica, v.Kranja_Stanica,
                    v.Vreme_Pocetka.ToString(), v.Vreme_Kraja.ToString(), v.Telefon_Narucivanja });
                lwVoznjaPrikaz.Items.Add(item);

            }

            lwVoznjaPrikaz.Refresh();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajVoznja voznjaForm = new DodajVoznja();
            voznjaForm.ShowDialog();
        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (lwVoznjaPrikaz.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite voznju cije podatke zelite da izmenite!");
                return;
            }

            string? id = lwVoznjaPrikaz.SelectedItems[0].SubItems[0].Text;

            if (int.TryParse(id, out int vId))
            {
                VoznjaBasic ob = await DTOManager.GetVoznjaBasic(vId);

                IzmeniVoznja edbForm = new(ob);

                if (edbForm.ShowDialog() == DialogResult.OK)
                {
                    await DTOManager.UpdateVoznjaBasic(edbForm.voznja);
                    popuniPodacima();
                }
            }
        }
        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lwVoznjaPrikaz.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite voznju koju zelite da obrisete!");
                return;
            }

            int idVoznje = Int32.Parse(lwVoznjaPrikaz.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu voznju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                await DTOManager.obrisiVoznju(idVoznje);
                MessageBox.Show("Brisanje voznje je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}