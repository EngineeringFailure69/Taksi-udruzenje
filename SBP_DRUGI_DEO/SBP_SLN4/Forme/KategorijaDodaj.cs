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
            string poruka = "Da li zelite da dodate novu kategoriju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                int izabraniID;
                if (!int.TryParse(cmbIdVozaca.SelectedValue.ToString(), out izabraniID))
                {
                    MessageBox.Show("Odaberite vazeci ID vozaca.");
                    return;
                }

                KategorijeBasic ob = new KategorijeBasic
                {
                    Id = new KategorijaIdBasic
                    {
                        Zaposleni = new ZaposleniBasic
                        {
                            OsobaId = izabraniID
                        },
                        Kategorija = tbKategorija.Text
                    }
                };

                await DTOManager.dodajKategoriju(ob);
                MessageBox.Show("Uspesno ste dodali novu kategoriju");
                this.Close();
            }
        }
    }
}