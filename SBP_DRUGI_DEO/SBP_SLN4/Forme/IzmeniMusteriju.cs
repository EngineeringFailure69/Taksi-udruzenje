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
           
        }
        public bool ProveriPraznaPolja()
        {
            return true;
        }

        private void IzmeniMusteriju_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
           
        }
    }
}
