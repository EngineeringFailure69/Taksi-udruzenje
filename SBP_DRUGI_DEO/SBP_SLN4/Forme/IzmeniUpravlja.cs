namespace SBP_SLN4.Forme
{
    public partial class IzmeniUpravlja : Form
    {
        public UpravljaBasic? upravljaBasic;
        public IzmeniUpravlja()
        {
            InitializeComponent();
        }
        public IzmeniUpravlja(UpravljaBasic ob) : this() 
        {
            upravljaBasic = ob;
            PopulateData();
        }

        public void PopulateData()
        {
            if (upravljaBasic != null)
            {
                tbVoziloID.Text = upravljaBasic.IdVozilo.ToString();
                tbVozacID.Text = upravljaBasic.IdVozac.ToString();
                tbDatumOd.Text = upravljaBasic.DatOd.ToString();
                tbDatumDo.Text = upravljaBasic.DatDo.ToString();
            }
        }
        public bool ProveriPraznjaPolja()
        {
            if (string.IsNullOrWhiteSpace(tbDatumOd.Text))
            {
                MessageBox.Show("Polje Datum od je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVozacID.Text))
            {
                MessageBox.Show("Polje VozacID je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVoziloID.Text))
            {
                MessageBox.Show("Polje VoziloID je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (upravljaBasic == null)
            {
                MessageBox.Show("Greska: Podaci o upravljanju nisu ucitani.");
                return;
            }
            string poruka = "Da li zelite da izmenite ovo upravljanje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (upravljaBasic != null && result == DialogResult.OK)
            {
                if (!ProveriPraznjaPolja()) return;
                upravljaBasic.IdVozac = int.Parse(tbVozacID.Text);
                upravljaBasic.IdVozilo = int.Parse(tbVoziloID.Text);
                upravljaBasic.DatDo = DateTime.Parse(tbDatumDo.Text);
                upravljaBasic.DatOd = DateTime.Parse(tbDatumOd.Text);

                await DTOManager.UpdateUpravljaBasic(upravljaBasic);
                MessageBox.Show("Uspesno ste izmenili ovo upravljanje!");
                this.Close();
            }

            Close();
        }
    }
}