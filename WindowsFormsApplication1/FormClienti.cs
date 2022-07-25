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
    public partial class FormClienti : Form
    {
        public int id { get; set; }
        public FormClienti()
        {
            InitializeComponent();
        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                Client client = Clienti.GetClient(id);
                id = client.Id;
                txtboxNume.Text = client.Nume;
                txtboxPrenume.Text = client.Prenume;
                txtboxTelefon.Text = client.Telefon;
                txtboxMail.Text = client.Mail;
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActClient_Click(object sender, EventArgs e)
        {
            if (Validare() == true)
            {
                Clienti.ClientAM(id, txtboxNume.Text, txtboxPrenume.Text, txtboxMail.Text, txtboxTelefon.Text);
                this.DialogResult = DialogResult.OK;
            }
            
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
            if (string.IsNullOrEmpty(txtboxTelefon.Text.Trim()))
            {
                MessageBox.Show("Introduceti telefon!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtboxMail.Text.Trim()))
            {
                MessageBox.Show("Introduceti Mail!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                int x = Int32.Parse(txtboxTelefon.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti sintaxa Telefon!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            
            return true;
        }
    }
}
