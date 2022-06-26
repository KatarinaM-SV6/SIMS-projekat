using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS_project.NaplatneStanice;

namespace SIMS_project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            AdminForm_Load();
        }

        private void AdminForm_Load()
        {
            NaplatneStanice.Items.Clear();
            List<NaplatnaStanica> naplatneStanice = Program.staniceRepo.GetAll();
            foreach (NaplatnaStanica naplatnaStanica in naplatneStanice)
            {
                NaplatneStanice.Items.Add(naplatnaStanica);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateNaplatnaStanica createNaplatnaStanica = new CreateNaplatnaStanica(null);
            createNaplatnaStanica.Show();
            AdminForm_Load();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (NaplatneStanice.SelectedItem != null)
            {
                UpdateForm updateForm = new UpdateForm((NaplatnaStanica)NaplatneStanice.SelectedItem);
                updateForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NaplatneStanice.SelectedItem != null)
            {
                Program.staniceRepo.Remove((NaplatnaStanica)NaplatneStanice.SelectedItem);
                AdminForm_Load();
            }
        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            AdminForm_Load();
        }
    }
}
