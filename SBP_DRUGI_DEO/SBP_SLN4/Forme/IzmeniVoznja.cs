namespace SBP_SLN4.Forme
{
    public partial class IzmeniVoznja : Form
    {
        public VoznjaBasic? voznja;
        public IzmeniVoznja()
        {
            InitializeComponent();
        }
        public IzmeniVoznja(VoznjaBasic v) : this()
        {
            voznja = v;
        }
        public void PostaviMaxLength()
        {
           
        }
        public bool ProveriPraznaPolja() 
        {
            return true;
        }
        public void populateInfos()
        {
          
        }
        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
          
        }
        private void IzmeniVoznja_Load(object sender, EventArgs e)
        {

        }
    }
}
