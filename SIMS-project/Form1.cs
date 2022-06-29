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
using SIMS_project.view.vodjaView;

namespace SIMS_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();

            //MainForm mainForm = new MainForm();
            //mainForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KorisnickiNalog nalog = Program.korisnickiNalogRepo.AttemptLogin(userName.Text, textBox1.Text);
            if (nalog != null)
            {
                if (nalog.TipKorisnika == TipKorisnika.ADMINISTRATOR)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                /*else if (nalog.TipKorisnika == TipKorisnika.VODJA_STANICE)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }*/

            }
        }
    }
}
