namespace SBP_SLN4.Forme
{
    public partial class MusterijePopusti : Form
    {
        public List<MusterijaPregled> popustPregled;
        public MusterijePopusti()
        {
            InitializeComponent();
        }

        public MusterijePopusti(List<MusterijaPregled> u) : this()
        {
            popustPregled = u;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            
         
        }

        private void MusterijePopusti_Load(object sender, EventArgs e)
        {

        }
    }
}