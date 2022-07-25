using proiect1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormProgramari : Form
    {
        public int id { get; set; }
        public int idClient { get; set; }
        public FormProgramari()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                Programare prog = Programari.GetProgramare(id);
                idClient = prog.IdClient;
                txtboxNume.Text = prog.Nume;
                txtboxPrenume.Text = prog.Prenume;
                txtboxServiciu.Text = prog.Serviciu;
                txtTelefon.Text = prog.Telefon;
                txtMail.Text = prog.Mail;
                dtpData.Value = prog.Data;
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizeazaProg_Click(object sender, EventArgs e)
        {
            if (Validare())
            {
                Programari.ProgramareAM(id, dtpData.Value, txtboxServiciu.Text, idClient, txtTelefon.Text, txtMail.Text, txtboxNume.Text, txtboxPrenume.Text);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void txtboxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Validare()
        {
            if (string.IsNullOrEmpty(txtboxNume.Text.Trim()))
            {
                MessageBox.Show("Introduceti numele!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtboxPrenume.Text.Trim()))
            {
                MessageBox.Show("Introduceti prenumele!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtboxServiciu.Text.Trim()))
            {
                MessageBox.Show("Introduceti serviciu!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefon.Text.Trim()))
            {
                MessageBox.Show("Introduceti telefon!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtMail.Text.Trim()))
            {
                MessageBox.Show("Introduceti Mail!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpData.Value < DateTime.Today)
            {
                MessageBox.Show("Introduceti Mail!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int temp;
            if (!int.TryParse(txtTelefon.Text.Trim(), out temp))
            {
                MessageBox.Show("Introduceti sintaxa Telefon!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            return true;
        }
    }
}
