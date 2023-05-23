using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodavnicaElektroOpreme
{
    public partial class Dobavljaci : Form
    {
        public Dobavljaci()
        {
            InitializeComponent();
            dgDobavljaci.AllowUserToAddRows = false;
            dgDobavljaci.AllowUserToDeleteRows = false;
            dgDobavljaci.ReadOnly = true;
            dgDobavljaci.AutoGenerateColumns = false;

            dgDobavljaci.Columns.Add("ID", "ID");
            dgDobavljaci.Columns["ID"].Visible = false;
            dgDobavljaci.Columns.Add("ImeProizvoda", "Ime");
            dgDobavljaci.Columns.Add("CenaProizvoda", "Cena Proizvoda");
            dgDobavljaci.Columns.Add("NaStanju", "Broj Proizvoda na stanju");
            dgDobavljaci.Columns.Add("ÏdNabavljaca", "ID nabavljaca");

            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

        }

        private void txtDisabled()
        {
            txtIme.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void txtEnabled()
        {
            txtIme.Enabled = true;
            txtEmail.Enabled = true;
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
            txtEmail.Text = "";
        }

        private void Dobavljaci_Load(object sender, EventArgs e)
        {

        }
    }
}
