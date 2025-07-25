namespace SBP_SLN4.Forme
{
    public partial class IzmeniVozilo : Form
    {
        public VoziloBasic? vozilo;
        public IzmeniVozilo()
        {
            InitializeComponent();
            tbTipVozila.Leave += tbTipVozila_Leave;
        }

        public IzmeniVozilo(VoziloBasic v) : this()
        {
            vozilo = v;
            populateInfos();
        }
        private void IzmeniVozilo_Load(object sender, EventArgs e)
        {
            tbTipVozila.TextChanged += new EventHandler(tbTipVozila_TextChanged);
        }
        public void populateInfos()
        {
            if (vozilo != null)
            {
                tbMarka.Text = vozilo.marka;
                tbTip.Text = vozilo.tip;
                tbTipVozila.Text = vozilo.tipVozila;
                tbGodinaProizvodnje.Text = vozilo.godinaProizvodnje.ToString();
                tbDatIstekaReg.Text = vozilo.DatIstekaReg.ToString();
                tbRegistarskaOznaka.Text = vozilo.RegOznaka;
                tbVlasnikId.Text = vozilo.VlasnikId.ToString();
                tbBoja.Text = vozilo.boja;
            }
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
            if (string.IsNullOrWhiteSpace(tbTipVozila.Text))
            {
                MessageBox.Show("Polje Tip vozila je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene vozila?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (vozilo != null && result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                vozilo.marka = tbMarka.Text;
                vozilo.tip = tbTip.Text;
                vozilo.tipVozila = tbTipVozila.Text;
                if (tbTipVozila.Text == "Licno_Vozilo")
                {
                    vozilo.VlasnikId = int.Parse(tbVlasnikId.Text);
                    vozilo.boja = tbBoja.Text;
                    vozilo.godinaProizvodnje = null;
                    vozilo.DatIstekaReg = null;
                    vozilo.RegOznaka = null;
                }
                if (tbTipVozila.Text == "Vozilo_Udruzenja")
                {
                    vozilo.VlasnikId = null;
                    vozilo.boja = null;
                    vozilo.godinaProizvodnje = int.Parse(tbGodinaProizvodnje.Text);
                    vozilo.DatIstekaReg = DateTime.Parse(tbDatIstekaReg.Text);
                    vozilo.RegOznaka = tbRegistarskaOznaka.Text;
                }

                await DTOManager.UpdateVoziloBasic(vozilo);
                MessageBox.Show("Azuriranje vozila je uspesno izvrseno!");
                this.Close();
            }
        }

        private void tbTipVozila_TextChanged(object sender, EventArgs e)
        {
            if (tbTipVozila.Text == "Licno_Vozilo")
            {
                tbGodinaProizvodnje.Enabled = false;
                tbDatIstekaReg.Enabled = false;
                tbRegistarskaOznaka.Enabled = false;
                tbVlasnikId.Enabled = true;
                tbBoja.Enabled = true;

            }
            if (tbTipVozila.Text == "Vozilo_Udruzenja")
            {
                tbVlasnikId.Enabled = false;
                tbBoja.Enabled = false;
                tbGodinaProizvodnje.Enabled = true;
                tbDatIstekaReg.Enabled = true;
                tbRegistarskaOznaka.Enabled = true;
            }
        }

        private void tbTipVozila_Leave(object sender, EventArgs e)
        {
            var validneVrednosti = new List<string> { "Licno_Vozilo", "Vozilo_Udruzenja" };

            // Provera da li unos nije validan
            if (!validneVrednosti.Contains(tbTipVozila.Text))
            {
                // Prikazivanje poruke korisniku
                MessageBox.Show("Dozvoljene vrednosti su 'Licno_Vozilo' ili 'Vozilo_Udruzenja'.", "Nevalidan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Postavljanje fokusa nazad na `TextBox`
                tbTipVozila.Focus();

                // Brisanje nevalidnog unosa
                tbTipVozila.Text = string.Empty;
            }
        }
    }
}
