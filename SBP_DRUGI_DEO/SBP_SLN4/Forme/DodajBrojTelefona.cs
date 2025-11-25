namespace SBP_SLN4.Forme
{
    public partial class DodajBrojTelefona : Form
    {
        public DodajBrojTelefona()
        {
            InitializeComponent();
            PostaviMaxLength();
        }
        private void DodajBrojTelefona_Load(object sender, EventArgs e)
        {
            List<int> osobaId = DTOManager.GetAllOsobaIDsFromBrojeviTelefona();
            cmbIdOsobe.DataSource = osobaId;
            cmbIdOsobe.DropDownStyle = ComboBoxStyle.DropDownList;
            PostaviMaxLength();
        }
        public void PostaviMaxLength()
        {
            tbBroj.MaxLength = 10;
        }
        public bool ProveriPraznaPolja() 
        {
            if (string.IsNullOrWhiteSpace(tbBroj.Text)) 
            {
                MessageBox.Show("Polje Broj telefona je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi broj telefona?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                int izabraniID;
                if (!int.TryParse(cmbIdOsobe.SelectedValue.ToString(), out izabraniID))
                {
                    MessageBox.Show("Odaberite vazeci ID osobe.");
                    return;
                }

                BrojeviTelefonaBasic ob = new BrojeviTelefonaBasic
                {
                    Id = new BrojeviTelefonaIdBasic
                    {
                        Osoba = new OsobaBasic
                        {
                            OsobaId = izabraniID
                        },
                        BrTel = tbBroj.Text
                    }
                };

                await DTOManager.dodajBroj(ob);
                MessageBox.Show("Uspesno ste dodali novi broj telefona!");
                this.Close();
            }
        }
        private void cmbIdOsobe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
