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
    public partial class UpdateForm : Form
    {
        NaplatnaStanica _stanica { get; set; }
        public UpdateForm(NaplatnaStanica stanica)
        {
            InitializeComponent();
            _stanica = stanica;
            Id.Text = stanica.Id.ToString();
            mesto.Text = stanica.Mesto.Naziv;
            nazivAutoputa.Text = stanica.NazivAutoputa;
        }

        public void load()
        {
            listBox1.Items.Clear();
            foreach (NaplatnoMesto naplatnoMesto in _stanica.NaplatnaMesta)
            {
                listBox1.Items.Add(naplatnoMesto);
            }
        }
        private void addBooth_Click(object sender, EventArgs e)
        {
            CreateNaplatnaStanica create = new CreateNaplatnaStanica(_stanica);
            create.ShowDialog();
        }

        private void updateBooth_Click(object sender, EventArgs e)
        {
            NaplatnoMesto mesto = (NaplatnoMesto)listBox1.SelectedItem;
            if (mesto != null)
            {
                UpdateBooth updateBooth = new UpdateBooth(_stanica.Mesto.Naziv, mesto);
                updateBooth.Show();
            }
        }

        private void deleteBooth_Click(object sender, EventArgs e)
        {
            NaplatnoMesto mesto = (NaplatnoMesto)listBox1.SelectedItem;
            if (mesto != null)
            {
                _stanica.NaplatnaMesta.Remove(mesto);
                Program.staniceRepo.Save();
                load();
            }
        }

        private void UpdateForm_Activated(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stanica.Mesto = new Mesto(mesto.Text);
            _stanica.NazivAutoputa = nazivAutoputa.Text;
            MessageBox.Show("Uspesno ste ažurirali naplatno mesto!", "Uspeh!");
            Close();
        }
    }
}
