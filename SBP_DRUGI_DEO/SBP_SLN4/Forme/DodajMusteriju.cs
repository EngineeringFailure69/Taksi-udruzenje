namespace SBP_SLN4.Forme
{
    public partial class DodajMusteriju : Form
    {
        public DodajMusteriju()
        {
            InitializeComponent();
            PostaviMaxLength();
        }

        public void PostaviMaxLength()
        {
            tbBrojTelefona.MaxLength = 10;
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
            if (string.IsNullOrWhiteSpace(tbBrojTelefona.Text)) 
            {
                MessageBox.Show("Polje Broj telefona je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbBrVoznji.Text)) 
            {
                MessageBox.Show("Polje Broj koriscenih voznji je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }

        private async void btndodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu musteriju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            MusterijaBasicBrojevi ob = new MusterijaBasicBrojevi();
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                ob.ulica = tbUlica.Text;
                ob.broj = tbBroj.Text;
                ob.Br_Koriscenih_Voznji = int.Parse(tbBrVoznji.Text);
                ob.BrojTelefona = tbBrojTelefona.Text;

                await DTOManager.dodajMusteriju(ob);
                MessageBox.Show("Uspesno ste dodali novu musteriju!");
                this.Close();
            }
        }

        private void DodajMusteriju_Load(object sender, EventArgs e)
        {
            PostaviMaxLength();
        }
    }
}