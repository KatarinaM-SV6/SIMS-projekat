using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS_project.Korisnici;
using SIMS_project.view.referentView;
using SIMS_project.view.vodjaView;

namespace SIMS_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AdminForm adminForm = new AdminForm();
            //adminForm.ShowDialog();

            //MainForm mainForm = new MainForm();
            //mainForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KorisnickiNalog nalog = Program.naloziRepo.AttemptLogin(userName.Text, textBox1.Text);
            if (nalog != null)
            {
                if (nalog.TipKorisnika == TipKorisnika.ADMINISTRATOR)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Closed += (s, args) => this.Close();
                    adminForm.ShowDialog();
                }
                else if (nalog.TipKorisnika == TipKorisnika.VODJA_STANICE)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.ShowDialog();
                    
                    
                }
                else if (nalog.TipKorisnika == TipKorisnika.REFERENT)
                {
                    this.Hide();
                    GlavnaForma refForm = new GlavnaForma(nalog);
                    refForm.Closed += (s, args) => this.Close();
                    refForm.ShowDialog();
                }
            } else
            {
                MessageBox.Show("Neispravni kredencijali");
                return;
            }
        }
    }
}
