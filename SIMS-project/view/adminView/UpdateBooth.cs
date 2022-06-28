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
    public partial class UpdateBooth : Form
    {
        NaplatnoMesto _naplatnoMesto;
        public UpdateBooth(String mesto, NaplatnoMesto naplatnoMesto)
        {
            InitializeComponent();
            _naplatnoMesto = naplatnoMesto;
            stanica.Text = mesto;
            id.Text = naplatnoMesto.RedniBroj.ToString();
            if (naplatnoMesto.UFunkciji)
                Da.Checked = true;
            else
                Ne.Checked = true;
            if (naplatnoMesto.ImaElektronskoNaplacivanje)
                radioButton2.Checked = true;
            else
                radioButton1.Checked = true;
            foreach (Uredjaj uredjaj in naplatnoMesto.Uredjaji)
            {
                if (uredjaj.VrstaUredjaja == VrstaUredjaja.KAMERA)
                    Kamera.Checked = true;
                else if (uredjaj.VrstaUredjaja == VrstaUredjaja.RAMPA)
                    Rampa.Checked = true;
                else if (uredjaj.VrstaUredjaja == VrstaUredjaja.SEMAFOR)
                    Semafor.Checked = true;
                else if (uredjaj.VrstaUredjaja == VrstaUredjaja.CITAC_TABLICA)
                    CitacTablica.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Da.Checked)
                _naplatnoMesto.UFunkciji = true;
            else
                _naplatnoMesto.UFunkciji = false;

            List<Uredjaj> uredjaji = new List<Uredjaj>();

            if (radioButton2.Checked)
            {
                _naplatnoMesto.ImaElektronskoNaplacivanje = true;
                uredjaji.Add(new Uredjaj("CITAC_TAGA"));
            }
            else
                _naplatnoMesto.ImaElektronskoNaplacivanje = false;


            if (Kamera.Checked) uredjaji.Add(new Uredjaj("KAMERA"));
            if (Semafor.Checked) uredjaji.Add(new Uredjaj("SEMAFOR"));
            if (Rampa.Checked) uredjaji.Add(new Uredjaj("RAMPA"));
            if (CitacTablica.Checked) uredjaji.Add(new Uredjaj("CITAC_TABLICA"));

            _naplatnoMesto.Uredjaji = uredjaji;
            Program.staniceRepo.Save();

            MessageBox.Show("Uspesno ste ažurirali naplatno mesto!", "Uspeh!");
            Close();
        }
    }
}
