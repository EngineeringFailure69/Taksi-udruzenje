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
            lwPrikazVozila.View = View.Details; 
            lwPrikazVozila.FullRowSelect = true; 
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
            DodajVozilo voziloForm = new DodajVozilo();
            voziloForm.ShowDialog();
        }
        private async void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            if (lwPrikazVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo cije podatke zelite da izmenite!");
                return;
            }

            string? id = lwPrikazVozila.SelectedItems[0].SubItems[0].Text;

            if (int.TryParse(id, out int vId))
            {
                VoziloBasic ob = await DTOManager.GetVoziloBasic(vId);

                IzmeniVozilo edbForm = new(ob);

                if (edbForm.ShowDialog() == DialogResult.OK)
                {
                    await DTOManager.UpdateVoziloBasic(edbForm.vozilo);
                    popuniPodacima();
                }
            }
        }
        private void btnUpravljanja_Click(object sender, EventArgs e)
        {
            UpravljaPrikaz1 upravljaForm = new UpravljaPrikaz1();
            upravljaForm.ShowDialog();
        }
        private  void btnIzabrno_Click(object sender, EventArgs e)
        {
            if (lwPrikazVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo cije istoriju upravljanja zelite da vidite!");
                return;
            }

            string? id = lwPrikazVozila.SelectedItems[0].SubItems[0].Text;

            if (int.TryParse(id, out int uId))
            {
                List<UpravljaPregled> ob =  DTOManager.GetIstorijaUpravljaBasic(uId);

                IstorijaUpravljanja edbForm = new(ob);

                if (edbForm.ShowDialog() == DialogResult.OK)
                {
                    edbForm.popuniPodacima();
                }
            }
        }
    }
}