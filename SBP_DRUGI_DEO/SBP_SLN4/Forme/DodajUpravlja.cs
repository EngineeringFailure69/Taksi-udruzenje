namespace SBP_SLN4.Forme
{
    public partial class DodajUpravlja : Form
    {
        public DodajUpravlja()
        {
            InitializeComponent();
        }

        public bool ProveriPraznjaPolja() 
        {
            if (string.IsNullOrWhiteSpace(tbDatumOd.Text)) 
            {
                MessageBox.Show("Polje Datum od je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo upravljanje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            UpravljaBasic ob = new UpravljaBasic();
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznjaPolja()) return;
                int izabraniVozacID;
                if (!int.TryParse(cmbVozacID.SelectedValue.ToString(), out izabraniVozacID))
                {
                    MessageBox.Show("Odaberite vazeci ID vozaca.");
                    return;
                }
                int izabranoVoziloID;
                if (!int.TryParse(cmbVoziloID.SelectedValue.ToString(), out izabranoVoziloID))
                {
                    MessageBox.Show("Odaberite vazeci ID vozila.");
                    return;
                }
                ob.IdVozac = izabraniVozacID; 
                ob.IdVozilo = izabranoVoziloID;
                if (string.IsNullOrWhiteSpace(tbDatumDo.Text))
                    ob.DatDo = null;
                else
                    ob.DatDo = DateTime.Parse(tbDatumDo.Text);
                ob.DatOd = DateTime.Parse(tbDatumOd.Text);

                await DTOManager.dodajUpravljanje(ob);
                MessageBox.Show("Uspesno ste dodali novo upravljanje!");
                this.Close();
            }
        }

        private void DodajUpravlja_Load(object sender, EventArgs e)
        {
            //Cmb VozacID
            List<int> vozacId = DTOManager.GetAllVozacIDsFromZaposleni();
            cmbVozacID.DataSource = vozacId;
            cmbVozacID.DropDownStyle = ComboBoxStyle.DropDownList;

            //Cmb VoziloID
            List<int> voziloId = DTOManager.GetAllVoziloIDsFromVozilo();
            cmbVoziloID.DataSource = voziloId;
            cmbVoziloID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
