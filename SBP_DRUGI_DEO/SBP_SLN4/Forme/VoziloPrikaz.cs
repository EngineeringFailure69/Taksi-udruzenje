
using System.Windows.Forms;

namespace SBP_SLN4.Forme
{
    public partial class VoziloPrikaz : Form
    {
        public VoziloPrikaz()
        {
            InitializeComponent();
        }

        private void VoziloPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            lwPrikazVozila.Items.Clear();
            lwPrikazVozila.View = View.Details; // Koristimo detaljan prikaz
            lwPrikazVozila.FullRowSelect = true; // Selektovanje cele redove
            lwPrikazVozila.GridLines = true;
            List<VoziloPregled> podaci = DTOManager.GetVoziloInfos();

            var firstItem = podaci[0];
            lwPrikazVozila.Columns.Add("ID");
            lwPrikazVozila.Columns.Add("Marka", 150);
            lwPrikazVozila.Columns.Add("Tip", 150);
            lwPrikazVozila.Columns.Add("Reg Oznaka", 100);
            lwPrikazVozila.Columns.Add("Ime Vlasnika", 150);
            lwPrikazVozila.Columns.Add("Boja", 100);

            foreach (VoziloPregled v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { v.VoziloId.ToString(), v.marka, v.tip, v.regOznaka, v.ImeVlasnika, v.boja });
                lwPrikazVozila.Items.Add(item);

            }

            lwPrikazVozila.Refresh();
        }

        private void lwPrikazVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VoziloPrikaz_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
        }

        private async void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpravljanja_Click(object sender, EventArgs e)
        {
        }

        private  void btnIzabrno_Click(object sender, EventArgs e)
        {
        }
    }
}