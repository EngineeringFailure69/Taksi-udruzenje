namespace SBP_SLN4.Forme
{
    public partial class DodajVozilo : Form
    {
        public DodajVozilo()
        {
            InitializeComponent();

            rbUdruzenje.CheckedChanged += new EventHandler(rbUdruzenje_CheckedChanged);
            rbLicno.CheckedChanged += new EventHandler(rbLicno_CheckedChanged);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public bool ProveriPraznaPolja() 
        {
            if (string.IsNullOrWhiteSpace(tbMarka.Text)) 
            {
                MessageBox.Show("Polje Marka je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTip.Text)) 
            {
                MessageBox.Show("Polje Tip je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private async void btnVozilo_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            VoziloBasic ob = new VoziloBasic();
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                ob.marka = tbMarka.Text;
                ob.tip = tbTip.Text;
                string tip = rbLicno.Text;
                if (rbLicno.Checked)
                {
                    int izabraniVlasnikID;
                    if (!int.TryParse(cmbVlasnikID.SelectedValue.ToString(), out izabraniVlasnikID))
                    {
                        MessageBox.Show("Odaberite vazeci ID vozaca.");
                        return;
                    }
                    ob.VlasnikId = izabraniVlasnikID;
                    ob.boja = tbBoja.Text;
                    tip = rbLicno.Text;
                    ob.godinaProizvodnje = null;
                    ob.DatIstekaReg = null;
                    ob.RegOznaka = null;
                }
                if (rbUdruzenje.Checked)
                {
                    ob.godinaProizvodnje = int.Parse(tbGodiste.Text);
                    ob.DatIstekaReg = DateTime.Parse(tbRegistracija.Text);
                    ob.RegOznaka = tbTablice.Text;
                    tip = rbUdruzenje.Text;
                    ob.VlasnikId = null;
                    ob.boja = null;
                }
                ob.tipVozila = tip;
                await DTOManager.dodajVozilo(ob);
                MessageBox.Show("Uspesno ste dodali novo vozilo!");
                this.Close();
            }
        }
        private void rbUdruzenje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUdruzenje.Checked)
            {
                tbBoja.Enabled = false;
                cmbVlasnikID.Enabled = false;
            }
                tbGodiste.Enabled = true;
                tbRegistracija.Enabled = true;
                tbTablice.Enabled = true;
        }
        private void rbLicno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLicno.Checked)
            {
                tbGodiste.Enabled = false;
                tbRegistracija.Enabled = false;
                tbTablice.Enabled = false;
            }
                cmbVlasnikID.Enabled = true;
                tbBoja.Enabled = true;
        }
        private void DodajVozilo_Load(object sender, EventArgs e)
        {
            rbLicno.Checked=true;

            //Cmb VlasnikID
            List<int> vozacId = DTOManager.GetAllVozacIDsFromZaposleni();
            cmbVlasnikID.DataSource = vozacId;
            cmbVlasnikID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}