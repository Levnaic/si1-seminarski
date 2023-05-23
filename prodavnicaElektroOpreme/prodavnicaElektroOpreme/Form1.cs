namespace prodavnicaElektroOpreme
{
    public partial class frmProizvodi : Form
    {
        List<Proizvod> proizvodList = new List<Proizvod>();
        string akcija = "";
        int indeksSelektovanog = -1;

        public frmProizvodi()
        {
            InitializeComponent();
            dgProizvodi.AllowUserToAddRows = false;
            dgProizvodi.AllowUserToDeleteRows = false;
            dgProizvodi.ReadOnly = true;
            dgProizvodi.AutoGenerateColumns = false;

            dgProizvodi.Columns.Add("ID", "ID");
            dgProizvodi.Columns["ID"].Visible = false;
            dgProizvodi.Columns.Add("ImeProizvoda", "Ime");
            dgProizvodi.Columns.Add("CenaProizvoda", "Cena Proizvoda");
            dgProizvodi.Columns.Add("NaStanju", "Broj Proizvoda na stanju");
            dgProizvodi.Columns.Add("ÏdNabavljaca", "ID nabavljaca");

            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();


        }

        private void txtDisabled()
        {
            txtIme.Enabled = false;
            txtCena.Enabled = false;
            txtBrojNaStanju.Enabled = false;
            txtIdDobavljaca.Enabled = false;
        }

        private void txtEnabled()
        {
            txtIme.Enabled = true;
            txtCena.Enabled = true;
            txtBrojNaStanju.Enabled = true;
            txtIdDobavljaca.Enabled = true;
        }

        private void btnChangeDisabled()
        {
            btnDodaj.Enabled = false;
            btnMenjaj.Enabled = false;
            btnBrisi.Enabled = false;

        }

        private void btnChangeEnabled()
        {
            btnDodaj.Enabled = true;
            btnMenjaj.Enabled = true;
            btnBrisi.Enabled = true;

        }

        private void btnSubmitDisabled()
        {
            btnPotvrdi.Enabled = false;
            btnOdustani.Enabled = false;
        }

        private void btnSubmitEnabled()
        {
            btnPotvrdi.Enabled = true;
            btnOdustani.Enabled = true;
        }

        private void ponistiUnosTxt()
        {
            txtIme.Text = "";
            txtCena.Text = "";
            txtBrojNaStanju.Text = "";
            txtIdDobavljaca.Text = "";
        }

        private void prikaziProizvodaTxt() 
        {
            int idSelektovanog = (int)dgProizvodi.SelectedRows[0].Cells["ID"].Value;
            Proizvod selektovaniProizvod = proizvodList.Where(x=> x.ID == idSelektovanog).FirstOrDefault();
            if (selektovaniProizvod!= null) 
            {
                txtIme.Text = selektovaniProizvod.Ime;
                txtCena.Text = selektovaniProizvod.Cena.ToString();
                txtBrojNaStanju.Text = selektovaniProizvod.NaStanju.ToString();
                txtIdDobavljaca.Text = selektovaniProizvod.IdDobavljaca.ToString();
            }
        }

        private void prikazProizvodaDGV() 
        {
            proizvodList = new Proizvod().ucitajProizvode();
            dgProizvodi.Rows.Clear();

            for (int i = 0; i < proizvodList.Count; i++) 
            {
                dgProizvodi.Rows.Add();
                dgProizvodi.Rows[i].Cells["ID"].Value = proizvodList[i].ID;
                dgProizvodi.Rows[i].Cells["ImeProizvoda"].Value = proizvodList[i].Ime;
                dgProizvodi.Rows[i].Cells["CenaProizvoda"].Value = proizvodList[i].Cena;
                dgProizvodi.Rows[i].Cells["NaStanju"].Value = proizvodList[i].NaStanju;
                dgProizvodi.Rows[i].Cells["IdDobavljaca"].Value = proizvodList[i].IdDobavljaca;
                // OVAJ DEO NIJI ISTI KAO WORD
            }

            ponistiUnosTxt();
            dgProizvodi.CurrentCell = null;

            if (proizvodList.Count > 0) 
            {
                if (indeksSelektovanog != -1) dgProizvodi.Rows[indeksSelektovanog].Selected = true;
                else dgProizvodi.Rows[0].Selected = true;
                prikaziProizvodaTxt();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ponistiUnosTxt();
            txtEnabled();
            btnSubmitEnabled();
            btnChangeDisabled();
            akcija = "dodaj";
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (akcija == "dodaj")
                {
                    Proizvod pro = new Proizvod();
                    pro.Ime = txtIme.Text;
                    pro.Cena = Int32.Parse(txtCena.Text);
                    pro.NaStanju = Int32.Parse(txtBrojNaStanju.Text);
                    pro.IdDobavljaca = Int32.Parse(txtIdDobavljaca.Text);
                    pro.dodajProizvod();
                    indeksSelektovanog = dgProizvodi.Rows.Count;
                
                }
                txtDisabled();
                btnSubmitDisabled();
                btnChangeEnabled();
                prikazProizvodaDGV();
            }
            catch (FormatException) 
            {
                MessageBox.Show("Greska pri unosu"); //prometniti da bude dinamicki
            }
        }
    }
}