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
using SIMS_project.Uredjaji;

namespace SIMS_project
{
    public partial class CreateNaplatnaStanica : Form
    {
        public CreateNaplatnaStanica()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
            NaplatnaStanica naplatnaStanica = new NaplatnaStanica(new Mesto(mesto.Text), new List<NaplatnoMesto>(), nazivAutoputa.Text);
            if (dodajNaplatnaMesta.Checked)
            {
                int brojMesta = Int32.Parse(brojNaplatnihMesta.Text);
                for (int j = 1; j <= brojMesta; j++)
                {
                    NaplatnoMesto naplatnoMesto;
                    if (j <= Int32.Parse(brojElektronskihMesta.Text))
                    {
                        naplatnoMesto = new NaplatnoMesto(j, true, true, j, new List<Uredjaj>());
                        naplatnoMesto.Uredjaji.Add(new Uredjaj("CITAC_TAGA"));
                    } else
                    {
                        naplatnoMesto = new NaplatnoMesto(j, false, true, j, new List<Uredjaj>());
                    }
                    if (kamera.Checked) naplatnoMesto.Uredjaji.Add(new Uredjaj("KAMERA"));
                    if (rampa.Checked) naplatnoMesto.Uredjaji.Add(new Uredjaj("RAMPA"));
                    if (citacTablica.Checked) naplatnoMesto.Uredjaji.Add(new Uredjaj("CITAC_TABLICA"));
                    if (semafor.Checked) naplatnoMesto.Uredjaji.Add(new Uredjaj("SEMAFOR"));
                    naplatnaStanica.NaplatnaMesta.Add(naplatnoMesto);
                }
            }
            Program.staniceRepo.Add(naplatnaStanica);
            Program.staniceRepo.Save();
        }

        private void dodajNaplatnaMesta_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = !splitContainer1.Panel2.Enabled;
        }
    }
}
