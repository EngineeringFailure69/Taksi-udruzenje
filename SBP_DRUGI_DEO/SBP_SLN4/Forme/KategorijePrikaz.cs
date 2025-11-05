
namespace SBP_SLN4.Forme
{
    public partial class KategorijePrikaz : Form
    {
        public KategorijePrikaz()
        {
            InitializeComponent();
        }

        private void KategorijePrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KategorijaDodaj dodajForm = new KategorijaDodaj();
            dodajForm.ShowDialog();
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            
        }
    }
}