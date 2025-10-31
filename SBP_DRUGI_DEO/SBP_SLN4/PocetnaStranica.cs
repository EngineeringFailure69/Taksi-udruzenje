namespace SBP_SLN4
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            VoziloPrikaz vozilaForm = new VoziloPrikaz();
            vozilaForm.ShowDialog();
        }
        private void btnUpravlja_Click(object sender, EventArgs e)
        {
            
        }
        private void btnVoznja_Click(object sender, EventArgs e)
        {
            VoznjaPrikaz voznjaForm = new VoznjaPrikaz();
            voznjaForm.ShowDialog();
        }
        private void btnZaposleni_Click(object sender, EventArgs e)
        {

        }
    }
}
