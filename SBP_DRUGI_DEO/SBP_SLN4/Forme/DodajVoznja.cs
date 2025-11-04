namespace SBP_SLN4.Forme
{
    public partial class DodajVoznja : Form
    {
        public DodajVoznja()
        {
            InitializeComponent();
            cmbIdMusterija.SelectedIndexChanged += cmbIdMusterija_SelectedIndexChanged;
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu voznju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            VoznjaBasic ob = new VoznjaBasic();
            if (result == DialogResult.OK)
            {
                if (!ProveriPraznaPolja()) return;
                int izabranaMusterijaID;
                if (!int.TryParse(cmbIdMusterija.SelectedValue.ToString(), out izabranaMusterijaID))
                {
                    MessageBox.Show("Odaberite vazeci ID administratora.");
                    return;
                }
                ob.MusterijaId = izabranaMusterijaID;
                ob.Pocetna_Stanica = tbPocetnaStanica.Text;
                ob.Kranja_Stanica = tbKrajnjaStanica.Text;
                ob.Br_Tel_Narucivanja = cmbBrTelMusterije.SelectedValue.ToString();
                int izabraniAdminID;
                if (!int.TryParse(cmbIdAdmin.SelectedValue.ToString(), out izabraniAdminID))
                {
                    MessageBox.Show("Odaberite vazeci ID administratora.");
                    return;
                }
                int izabraniVozacID;
                if (!int.TryParse(cmbIdVozac.SelectedValue.ToString(), out izabraniVozacID))
                {
                    MessageBox.Show("Odaberite vazeci ID vozaca.");
                    return;
                }
                ob.AdminId = izabraniAdminID;
                ob.Vreme_Javljanja = DateTime.Parse(tbVremeJavljanja.Text);
                ob.Br_Tel_Prim_Poziva = cmbBrTelAdmin.SelectedValue.ToString();
                ob.VozacId = izabraniVozacID;
                ob.Vreme_Pocetka = DateTime.Parse(tbVremePocetka.Text);
                if (string.IsNullOrWhiteSpace(tbVremeKraja.Text))
                    ob.Vreme_Kraja = null;
                else
                    ob.Vreme_Kraja = DateTime.Parse(tbVremeKraja.Text);

                await DTOManager.dodajVoznju(ob);
                MessageBox.Show("Uspesno ste dodali novu voznju!");
                this.Close();
            }
        }
        private void DodajVoznja_Load(object sender, EventArgs e)
        {
            //Cmb AdminID
            List<int> adminId = DTOManager.GetAllAdminIDsFromZaposleni();
            cmbIdAdmin.DataSource = adminId;
            cmbIdAdmin.DropDownStyle = ComboBoxStyle.DropDownList;

            //Cmb VozacID
            List<int> vozacId = DTOManager.GetAllVozacIDsFromZaposleni();
            cmbIdVozac.DataSource = vozacId;
            cmbIdVozac.DropDownStyle = ComboBoxStyle.DropDownList;

            //Cmb MusterijaID
            List<int> musterijaId = DTOManager.GetAllMusterijaIDsFromMusterija();
            cmbIdMusterija.DataSource = musterijaId;
            cmbIdMusterija.DropDownStyle = ComboBoxStyle.DropDownList;

            //Cmb BrTelMusterije
            if (cmbIdMusterija.SelectedValue != null)
            {
                int izabranaMusterijaID;
                if (int.TryParse(cmbIdMusterija.SelectedValue.ToString(), out izabranaMusterijaID))
                {
                    List<string> BrTel = DTOManager.GetAllTelefoniZaMusterije(izabranaMusterijaID)
                                                    .Select(bt => bt.BrojTelefona)
                                                    .ToList();
                    cmbBrTelMusterije.DataSource = BrTel;
                    cmbBrTelMusterije.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Izabrani ID musterije nije validan.");
                }
            }
            else
            {
                MessageBox.Show("Nijedna musterija nije izabrana.");
            }
            //Cmb BrTelAdmin
            if (cmbIdAdmin.SelectedValue != null)
            {
                int izabraniAdminID;
                if (int.TryParse(cmbIdAdmin.SelectedValue.ToString(), out izabraniAdminID))
                {
                    List<string> BrTel = DTOManager.GetAllTelefoniZaMusterije(izabraniAdminID)
                                                    .Select(bt => bt.BrojTelefona)
                                                    .ToList();
                    cmbBrTelAdmin.DataSource = BrTel;
                    cmbBrTelAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Izabrani ID musterije nije validan.");
                }
            }
            else
            {
                MessageBox.Show("Nijedna musterija nije izabrana.");
            }
        }
        private void cmbIdMusterija_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Cmb BrTelMusterije
            if (cmbIdMusterija.SelectedValue != null)
            {
                int izabranaMusterijaID;
                if (int.TryParse(cmbIdMusterija.SelectedValue.ToString(), out izabranaMusterijaID))
                {
                    List<string> BrTel = DTOManager.GetAllTelefoniZaMusterije(izabranaMusterijaID)
                                                    .Select(bt => bt.BrojTelefona)
                                                    .ToList();
                    cmbBrTelMusterije.DataSource = BrTel;
                    cmbBrTelMusterije.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Izabrani ID musterije nije validan.");
                }
            }
            else
            {
                cmbBrTelMusterije.DataSource = null;
                MessageBox.Show("Nijedna musterija nije izabrana.");
            }
        }
        private void cmbIdAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Cmb BrTelPrimPoziva
            if (cmbIdAdmin.SelectedValue != null)
            {
                int izabraniAdminID;
                if (int.TryParse(cmbIdAdmin.SelectedValue.ToString(), out izabraniAdminID))
                {
                    List<string> BrTel = DTOManager.GetAllTelefoniZaMusterije(izabraniAdminID)
                                                    .Select(bt => bt.BrojTelefona)
                                                    .ToList();
                    cmbBrTelAdmin.DataSource = BrTel;
                    cmbBrTelAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Izabrani ID admin-a nije validan.");
                }
            }
            else
            {
                cmbBrTelAdmin.DataSource = null;
                MessageBox.Show("Nijedan admin nije izabrana.");
            }
        }
        public bool ProveriPraznaPolja()
        {
            if (string.IsNullOrWhiteSpace(tbPocetnaStanica.Text))
            {
                MessageBox.Show("Polje Pocetna stanica je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbKrajnjaStanica.Text))
            {
                MessageBox.Show("Polje Krajnja stanica je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVremeJavljanja.Text))
            {
                MessageBox.Show("Polje Vreme javljanja je obavezno, morate ga popuniti!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbVremePocetka.Text))
            {
                MessageBox.Show("Polje Vreme pocetka je obavezno, morate ga popuniti!");
                return false;
            }
            return true;
        }
    }
}