namespace SBP_SLN4.Forme
{
    public partial class IzmeniZaposlenog : Form
    {
        public ZaposleniBasic? zaposleni;
        public IzmeniZaposlenog()
        {
            InitializeComponent();
            tbTipZaposlenog.Validating += tbTipZaposlenog_Validating;
            tbTipZaposlenog.Leave += tbTipZaposlenog_Leave;
        }
        public IzmeniZaposlenog(ZaposleniBasic z) : this()
        {
            zaposleni = z;
            populateInfos();
        }
        public void populateInfos()
        {
            if (zaposleni != null)
            {
                tbUlica.Text = zaposleni.ulica;
                tbBroj.Text = zaposleni.broj;
                tbTipOsobe.Text = zaposleni.Tip_Osobe;
                tbLime.Text = zaposleni.lime;
                tbSrSlovo.Text = zaposleni.SrSlovo;
                tbPrezime.Text = zaposleni.prezime;
                tbJMBG.Text = zaposleni.jmbg;
                tbTipZaposlenog.Text = zaposleni.Tip_Zaposlenog;
                tbBrVozacke.Text = zaposleni.Broj_Vozacke;
                tbStrucnaSprema.Text = zaposleni.Strucna_Sprema;
            }
        }
        public bool ProveriPraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(tbUlica.Text))
            {
                MessageBox.Show("Polje Ulica je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbBroj.Text))
            {
                MessageBox.Show("Polje Broj je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbLime.Text))
            {
                MessageBox.Show("Polje Licno ime je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbSrSlovo.Text))
            {
                MessageBox.Show("Polje Srednje slovo je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPrezime.Text))
            {
                MessageBox.Show("Polje Prezime je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbJMBG.Text))
            {
                MessageBox.Show("Polje JMBG je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTipZaposlenog.Text))
            {
                MessageBox.Show("Polje Tip zaposlenog je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private void IzmeniZaposlenog_Load(object sender, EventArgs e)
        {
            cbOsobaInfo.Checked = true;
            tbTipOsobe.Enabled = false;
            tbTipZaposlenog.TextChanged += new EventHandler(tbTipZaposlenog_TextChanged);
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (zaposleni == null)
            {
                MessageBox.Show("Greska: Podaci o zaposlenom nisu ucitani.");
                return;
            }
            string poruka = "Da li zelite da izmenite ovog zaposlenog";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (zaposleni != null && result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                zaposleni.ulica = tbUlica.Text;
                zaposleni.broj = tbBroj.Text;
                zaposleni.Tip_Osobe = tbTipOsobe.Text;
                if (tbTipZaposlenog.Text == "Vozac")
                {
                    zaposleni.Strucna_Sprema = null;
                    zaposleni.Broj_Vozacke = tbBrVozacke.Text;
                }
                if (tbTipZaposlenog.Text == "Administrator")
                {
                    zaposleni.Broj_Vozacke = null;
                    zaposleni.Strucna_Sprema = tbStrucnaSprema.Text;
                }
                zaposleni.lime = tbLime.Text;
                zaposleni.SrSlovo = tbSrSlovo.Text;
                zaposleni.prezime = tbPrezime.Text;
                zaposleni.jmbg = tbJMBG.Text;
                zaposleni.Tip_Zaposlenog = tbTipZaposlenog.Text;

                await DTOManager.UpdateZaposleniBasic(zaposleni);
                MessageBox.Show("Uspesno ste izmenili ovog zaposlenog!");
                this.Close();
            }

            Close();
        }

        private void cbOsobaInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOsobaInfo.Checked == false)
            {
                tbUlica.Enabled = false;
                tbBroj.Enabled = false;
            }
            else
            {
                tbUlica.Enabled = true;
                tbBroj.Enabled = true;
            }
        }

        private void tbTipZaposlenog_TextChanged(object sender, EventArgs e)
        {
            if (tbTipZaposlenog.Text == "Vozac")
            {
                tbStrucnaSprema.Enabled = false;
                tbBrVozacke.Enabled = true;
            }
            if (tbTipZaposlenog.Text == "Administrator")
            {
                tbBrVozacke.Enabled = false;
                tbStrucnaSprema.Enabled = true;
            }
            var validneVrednosti = new List<string> { "Administrator", "Vozac" };
        }

        private void tbTipZaposlenog_Validating(object sender, CancelEventArgs e) { }

        private void tbTipZaposlenog_Leave(object sender, EventArgs e)
        {
            var validneVrednosti = new List<string> { "Administrator", "Vozac" };
            if (!validneVrednosti.Contains(tbTipZaposlenog.Text))
            {
                MessageBox.Show("Dozvoljene vrednosti su 'Administrator' ili 'Vozac'.", "Nevalidan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTipZaposlenog.Focus();
                tbTipZaposlenog.Text = string.Empty;
            }
        }
    }
}