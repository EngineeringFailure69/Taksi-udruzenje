namespace SBP_SLN4.Forme
{
    public partial class KategorijaDodaj : Form
    {
        public KategorijaDodaj()
        {
            InitializeComponent();
        }

        private void KategorijaDodaj_Load(object sender, EventArgs e)
        {
            //Cmb VozacID
            List<int> vozacId = DTOManager.GetAllVozacIDsFromZaposleni();
            cmbIdVozaca.DataSource = vozacId;
            cmbIdVozaca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public bool ProveriPraznaPolja() 
        {
            if (string.IsNullOrWhiteSpace(tbKategorija.Text)) 
            {
                MessageBox.Show("Polje Kategorija je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            
        }
    }
}
