namespace SBP_SLN4.Forme
{
    public partial class IzmeniVoznja : Form
    {
        public VoznjaBasic? voznja;
        public IzmeniVoznja()
        {
            InitializeComponent();
            PostaviMaxLength();
        }
        public IzmeniVoznja(VoznjaBasic v) : this()
        {
            voznja = v;
            populateInfos();
        }
        public void PostaviMaxLength()
        {
            tbTelNarucivanja.MaxLength = 10;
            tbTelPrimljenogPoziva.MaxLength = 10;
        }
        public bool ProveriPraznaPolja() 
        {
            if (string.IsNullOrWhiteSpace(tbMusterijaID.Text))
            {
                MessageBox.Show("Polje MusterijaID je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPocetnaStanica.Text))
            {
                MessageBox.Show("Polje Pocetna stanica je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbKrajnjaStanica.Text))
            {
                MessageBox.Show("Polje Krajnja stanica je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTelNarucivanja.Text))
            {
                MessageBox.Show("Polje Br. tel. narucivanja je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbAdminID.Text))
            {
                MessageBox.Show("Polje AdminID je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTelPrimljenogPoziva.Text))
            {
                MessageBox.Show("Polje Br. tel. primljenog poziva je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVozacID.Text))
            {
                MessageBox.Show("Polje VozacID je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVremeJavljanja.Text))
            {
                MessageBox.Show("Polje Vreme javljanja je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVremePocetka.Text))
            {
                MessageBox.Show("Polje Vreme pocetka je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        public void populateInfos()
        {
            if (voznja != null)
            {
                tbMusterijaID.Text = voznja.MusterijaId.ToString();
                tbPocetnaStanica.Text = voznja.Pocetna_Stanica;
                tbKrajnjaStanica.Text = voznja.Kranja_Stanica;
                tbTelNarucivanja.Text = voznja.Br_Tel_Narucivanja;
                tbAdminID.Text = voznja.AdminId.ToString();
                tbVremeJavljanja.Text = voznja.Vreme_Javljanja.ToString();
                tbTelPrimljenogPoziva.Text = voznja.Br_Tel_Prim_Poziva;
                tbVozacID.Text = voznja.VozacId.ToString();
                tbVremePocetka.Text = voznja.Vreme_Pocetka.ToString();
                tbVremeKraja.Text = voznja.Vreme_Kraja.ToString();
            }
        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (voznja == null)
            {
                MessageBox.Show("Greska: Podaci o voznji nisu ucitani.");
                return;
            }
            string poruka = "Da li zelite da izmenite ovu voznju";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (voznja != null && result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                voznja.MusterijaId = int.Parse(tbMusterijaID.Text);
                voznja.Pocetna_Stanica = tbPocetnaStanica.Text;
                voznja.Kranja_Stanica = tbKrajnjaStanica.Text;
                voznja.Br_Tel_Narucivanja = tbTelNarucivanja.Text;
                voznja.AdminId = int.Parse(tbAdminID.Text);
                voznja.Vreme_Javljanja = DateTime.Parse(tbVremeJavljanja.Text);
                voznja.Br_Tel_Prim_Poziva = tbTelPrimljenogPoziva.Text;
                voznja.VozacId = int.Parse(tbVozacID.Text);
                voznja.Vreme_Pocetka = DateTime.Parse(tbVremePocetka.Text);
                voznja.Vreme_Kraja = DateTime.Parse(tbVremeKraja.Text);

                await DTOManager.UpdateVoznjaBasic(voznja);
                MessageBox.Show("Uspesno ste izmenili ovu voznju!");
                this.Close();
            }

            Close();
        }
        private void IzmeniVoznja_Load(object sender, EventArgs e)
        {
            PostaviMaxLength();
        }
    }
}
