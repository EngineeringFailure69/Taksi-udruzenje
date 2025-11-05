namespace SBP_SLN4.Forme
{
    public partial class BrojeviTelefonaPrikaz : Form
    {
        public BrojeviTelefonaPrikaz()
        {
            InitializeComponent();
        }

        private void BrojeviTelefonaPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajBrojTelefona dodajBrojForm = new DodajBrojTelefona();
            dodajBrojForm.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            
        }
    }
}
