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
    public partial class Home : Form
    {
        private BindingSource bsProgramari = new BindingSource();
        private BindingSource bsClienti = new BindingSource();
        List<Client> clienti;
        List<Programare> programari;
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgClienti.AutoGenerateColumns = false;
            dgProgramari.AutoGenerateColumns = false;
            LoadData();


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnReincarca_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            Programare programare = new Programare();
            programari = Programari.GetProgramari(dtpData.Value);
            bsProgramari.DataSource = programari;
            dgProgramari.DataSource = bsProgramari;

            Client client = new Client();
            clienti = Clienti.GetClienti();
            bsClienti.DataSource = clienti;
            dgClienti.DataSource = bsClienti;
        }

        private void btnActualizeazaProg_Click(object sender, EventArgs e)
        {
            if (tc.SelectedTab == tc.TabPages["tpProgramari"])
            {
                Programare p = bsProgramari.Current as Programare;
                if (p == null)
                {
                    return;
                }
                FormProgramari frmP = new FormProgramari();
                frmP.StartPosition = FormStartPosition.CenterScreen;
                frmP.id = p.Id;

                DialogResult dr = frmP.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    LoadData();
                }
                frmP.Dispose();
            }
            else
            {
                Client c = bsClienti.Current as Client;
                if (c == null)
                {
                    return;
                }
                FormClienti frmC = new FormClienti();
                frmC.StartPosition = FormStartPosition.CenterScreen;
                frmC.id = c.Id;
                DialogResult dr = frmC.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    LoadData();
                }
                frmC.Dispose();
            }

            

        }

        private void btnStergeProg_Click(object sender, EventArgs e)
        {
            if (tc.SelectedTab == tc.TabPages["tpProgramari"])
            {
                Programare p = bsProgramari.Current as Programare;
                DialogResult dr = MessageBox.Show("Sigur doriti sa stergeti?",
                          "STERGERE", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Programari.DeleteProgramare(p.Id);
                        LoadData();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                Client c = bsClienti.Current as Client;
                DialogResult dr = MessageBox.Show("Sigur doriti sa stergeti?",
                          "STERGERE", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Clienti.DeleteClient(c.Id);
                        LoadData();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            

            
            
        }

        private void btnAdaugaProg_Click(object sender, EventArgs e)
        {
            if (tc.SelectedTab == tc.TabPages["tpProgramari"])
            {
                Programare p = bsProgramari.Current as Programare;
                FormProgramari frmP = new FormProgramari();
                frmP.StartPosition = FormStartPosition.CenterScreen;
                frmP.id = 0;

                DialogResult dr = frmP.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    LoadData();
                }
                frmP.Dispose();
            }
            else
            {
                Client c = bsClienti.Current as Client;
                FormClienti frmC = new FormClienti();
                frmC.StartPosition = FormStartPosition.CenterScreen;
                frmC.id = 0;

                DialogResult dr = frmC.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    LoadData();
                }
                frmC.Dispose();
            }
            
        }
    }
}
