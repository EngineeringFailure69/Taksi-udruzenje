namespace SBP_SLN4.Forme
{
    public partial class DodajZaposleni : Form
    {
        public DodajZaposleni()
        {
            InitializeComponent();
            PostaviMaxLength();
            tbTipZaposlenog.Validating += tbTipZaposlenog_Validating;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            ZaposleniBasicBrojevi ob = new ZaposleniBasicBrojevi();
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                ob.ulica = tbUlica.Text;
                ob.broj = tbBroj.Text;
                ob.lime = tbLime.Text;
                ob.SrSlovo = tbSrSlovo.Text;
                ob.prezime = tbPrezime.Text;
                ob.jmbg = tbJMBG.Text;
                ob.Tip_Zaposlenog = tbTipZaposlenog.Text;
                ob.Broj_Vozacke = tbBrVozacke.Text;
                ob.Strucna_Sprema = tbStrucnaSprema.Text;
                ob.BrojTelefona = tbTelefon.Text;

                await DTOManager.dodajZaposlenog(ob);
                MessageBox.Show("Uspesno ste dodali novog zaposlenog!");
                this.Close();
            }
        }

        public void PostaviMaxLength()
        {
            tbTelefon.MaxLength = 10;
            tbJMBG.MaxLength = 13;
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
            if (string.IsNullOrWhiteSpace(tbTelefon.Text))
            {
                MessageBox.Show("Polje Broj telefona je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private void DodajZaposleni_Load(object sender, EventArgs e)
        {
            tbTipZaposlenog.TextChanged += new EventHandler(tbTipZaposlenog_TextChanged);
            PostaviMaxLength();
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
        }

        private void tbTipZaposlenog_Validating(object sender, CancelEventArgs e)
        {
            var validneVrednosti = new List<string> { "Administrator", "Vozac" };

            // Provera da li unos nije validan
            if (!validneVrednosti.Contains(tbTipZaposlenog.Text))
            {
                // Prikazivanje poruke korisniku
                MessageBox.Show("Dozvoljene vrednosti su 'Administrator' ili 'Vozac'.", "Nevalidan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Postavljanje fokusa nazad na textbox
                tbTipZaposlenog.Focus();

                // Sprecavanje prelaska na sledecu kontrolu
                e.Cancel = true;

                // Brisanje nevalidnog unosa
                tbTipZaposlenog.Text = string.Empty;
            }
        }
    }
}
