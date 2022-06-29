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
using SIMS_project.NaplatneStanice;
using SIMS_project.view.adminView;

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
            KorisnickiNaloziLB.Items.Clear();
            List<KorisnickiNalog> korisnickiNalozi = Program.korisnickiNalogRepo.GetAll();
            foreach (var nalog in korisnickiNalozi)
            {
                KorisnickiNaloziLB.Items.Add(nalog);
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

        private void button1_Click(object sender, EventArgs e)
        {
            KorisnickiNalog nalog = radnici.SelectedItem as KorisnickiNalog;
            NaplatnaStanica stanica = stanice.SelectedItem as NaplatnaStanica;


            if (nalog != null && stanica != null)
            {
                if (stanica.VodjaStanice != null)
                {
                    DialogResult dr = MessageBox.Show("Stanica vec ima postavljenog vodju. Da li zelite da ga smenite?",
                      "Provera", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            {
                                noviVodja(nalog, stanica);
                                break;
                            }
                            
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                }
                else
                {
                    noviVodja(nalog, stanica);
                }
            }
            poruka.Text = "Uspesno postavljen vodja na stanicu!";
        }

        private void noviVodja(KorisnickiNalog nalog, NaplatnaStanica stanica)
        {
            nalog.TipKorisnika = TipKorisnika.VODJA_STANICE;
            nalog.Korisnik.RadnoMesto = stanica;
            stanica.VodjaStanice = nalog.Korisnik;

            Program.korisnickiNalogRepo.Save();
            Program.korisniciRepo.Save();
            Program.staniceRepo.Save();

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            List<KorisnickiNalog> korisnici = Program.korisnickiNalogRepo.GetAll();
            foreach (KorisnickiNalog radnik in korisnici)
            {
                if (radnik.TipKorisnika == TipKorisnika.VODJA_STANICE || radnik.TipKorisnika == TipKorisnika.REFERENT)
                {
                    radnici.Items.Add(radnik);
                }
            }
            foreach (NaplatnaStanica stanica in Program.staniceRepo.GetAll())
            {
                stanice.Items.Add(stanica);
            }
            
        }

        private void updateNalogBt_Click(object sender, EventArgs e)
        {
            if (KorisnickiNaloziLB.SelectedItem != null)
            {
                UpdateNalogForm updateNalogForm = new UpdateNalogForm((KorisnickiNalog)KorisnickiNaloziLB.SelectedItem);
                updateNalogForm.Show();
            }
        }

        private void deleteNalogBt_Click(object sender, EventArgs e)
        {
            if (KorisnickiNaloziLB.SelectedItem != null)
            {
                KorisnickiNalog nalog = (KorisnickiNalog)KorisnickiNaloziLB.SelectedItem;
                if (nalog.Korisnik.RadnoMesto.VodjaStanice == nalog.Korisnik)
                    nalog.Korisnik.RadnoMesto.VodjaStanice = null;


                nalog.Korisnik.RadnoMesto.Radnici.Remove(nalog.Korisnik);
                Program.korisnickiNalogRepo.Remove(nalog);
                AdminForm_Load();
            }
        }

        private void createNalogBt_Click(object sender, EventArgs e)
        {
            UpdateNalogForm createNalogForm = new UpdateNalogForm(null);
            createNalogForm.Show();
        }

    }
}
