namespace SBP_SLN4.Forme
{
    public partial class DodajBrojTelefona : Form
    {
        public DodajBrojTelefona()
        {
            InitializeComponent();
            PostaviMaxLength();
        }
        private void DodajBrojTelefona_Load(object sender, EventArgs e)
        {
            
        }
        public void PostaviMaxLength()
        {
            tbBroj.MaxLength = 10;
        }
        public bool ProveriPraznaPolja() 
        {
            if (string.IsNullOrWhiteSpace(tbBroj.Text)) 
            {
                MessageBox.Show("Polje Broj telefona je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbIdOsobe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
