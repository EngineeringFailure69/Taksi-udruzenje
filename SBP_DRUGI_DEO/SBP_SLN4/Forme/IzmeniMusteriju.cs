namespace SBP_SLN4.Forme
{
    public partial class IzmeniMusteriju : Form
    {
        public MusterijaBasic? musterija;
        public IzmeniMusteriju()
        {
            InitializeComponent();
        }
        public IzmeniMusteriju(MusterijaBasic m) : this()
        {
            musterija = m;
            populateInfos();
        }

        public void populateInfos()
        {
            if (musterija != null)
            {
                tbUlica.Text = musterija.ulica;
                tbBroj.Text = musterija.broj;
                tbTipOsobe.Text = musterija.Tip_Osobe;
                tbBrVoznji.Text = musterija.Br_Koriscenih_Voznji.ToString();
            }
        }
        public bool ProveriPraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(tbBroj.Text))
            {
                MessageBox.Show("Polje Broj je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbUlica.Text))
            {
                MessageBox.Show("Polje Ulica je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbBrVoznji.Text))
            {
                MessageBox.Show("Polje Broj koriscenih voznji je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private void IzmeniMusteriju_Load(object sender, EventArgs e)
        {
            tbTipOsobe.Enabled = false;
        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (musterija == null)
            {
                MessageBox.Show("Greška: Podaci o musteriji nisu učitani.");
                return;
            }
            string poruka = "Da li zelite da izmenite ovu musteriju";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (musterija != null && result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                musterija.ulica = tbUlica.Text;
                musterija.broj = tbBroj.Text;
                musterija.Tip_Osobe = tbTipOsobe.Text;
                musterija.Br_Koriscenih_Voznji = int.Parse(tbBrVoznji.Text);

                await DTOManager.UpdateMusterijaBasic(musterija);
                MessageBox.Show("Uspesno ste izmenili ovu musteriju!");
                this.Close();
            }

            Close();
        }
    }
}