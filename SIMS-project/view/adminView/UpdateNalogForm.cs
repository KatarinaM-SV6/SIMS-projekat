using SIMS_project.Korisnici;
using SIMS_project.NaplatneStanice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_project.view.adminView
{
    public partial class UpdateNalogForm : Form
    {
        KorisnickiNalog _nalog { get; set; }
        public UpdateNalogForm(KorisnickiNalog nalog)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(TipKorisnika));
            comboBox2.DataSource = Program.staniceRepo.GetAll();
            if (nalog != null)
            {
                _nalog = nalog;
                load();
                button2.Enabled = false;
            }
            else 
            { 
                button1.Enabled = false;
            }
            
        }
        private void load()
        {
            textBox1.Text = _nalog.KorisnickoIme;
            textBox2.Text = _nalog.Lozinka;
            textBox3.Text = _nalog.Korisnik.Ime;
            textBox4.Text = _nalog.Korisnik.Prezime;
            comboBox1.SelectedItem = _nalog.TipKorisnika;
            comboBox2.SelectedItem = _nalog.Korisnik.RadnoMesto;
        }
        // update button
        private void button1_Click(object sender, EventArgs e)
        {
            KorisnickiNalog nalog = Program.korisnickiNalogRepo.GetById(_nalog.Id);
            if (nalog != null)
            {
                string korisnickoIme = textBox1.Text;
                if (korisnickoIme == nalog.KorisnickoIme) { }
                else if (Program.korisnickiNalogRepo.GetByUsername(korisnickoIme).Count() != 0)
                { 
                    MessageBox.Show("Korisnicko ime je zauzeto");
                    return;
                }
                nalog.KorisnickoIme = korisnickoIme;
                nalog.Lozinka = textBox2.Text;
                nalog.Korisnik.Ime = textBox3.Text;
                nalog.Korisnik.Prezime = textBox4.Text;
                nalog.TipKorisnika = (TipKorisnika)comboBox1.SelectedItem;
                nalog.Korisnik.RadnoMesto = (NaplatnaStanica)comboBox2.SelectedItem;

                if (nalog.TipKorisnika == TipKorisnika.ADMINISTRATOR)
                    nalog.Korisnik.RadnoMesto = null;
                else if (nalog.Korisnik.RadnoMesto != (NaplatnaStanica)comboBox2.SelectedItem) 
                {
                    nalog.Korisnik.RadnoMesto.Radnici.Remove(nalog.Korisnik);
                }
                    nalog.Korisnik.RadnoMesto = (NaplatnaStanica)comboBox2.SelectedItem;
                
                    

                if (nalog.Korisnik.RadnoMesto != null)
                {
                    NaplatnaStanica stanica = (NaplatnaStanica)comboBox2.SelectedItem;
                    if (nalog.TipKorisnika == TipKorisnika.VODJA_STANICE)
                        stanica.VodjaStanice = nalog.Korisnik;
                    stanica.Radnici.Add(nalog.Korisnik);
                }
                Program.korisnickiNalogRepo.Save();
                Program.korisniciRepo.Save();
                Program.staniceRepo.Save();
                this.Close();
            }
            
        }
        // add button
        private void button2_Click(object sender, EventArgs e)
        { 
            KorisnickiNalog nalog = new KorisnickiNalog();
            string korisnickoIme = textBox1.Text;
            if (Program.korisnickiNalogRepo.GetByUsername(korisnickoIme).Count() != 0)
            {
                MessageBox.Show("Korisnicko ime je zauzeto");
                return;
            }
            nalog.KorisnickoIme = korisnickoIme;
            nalog.Lozinka = textBox2.Text;
            nalog.Korisnik = new Korisnik();
            nalog.Korisnik.Ime = textBox3.Text;
            nalog.Korisnik.Prezime = textBox4.Text;
            nalog.TipKorisnika = (TipKorisnika)comboBox1.SelectedItem;
            if (nalog.TipKorisnika == TipKorisnika.ADMINISTRATOR)
                nalog.Korisnik.RadnoMesto = null;
            else
                nalog.Korisnik.RadnoMesto = (NaplatnaStanica)comboBox2.SelectedItem;
                
            Program.korisnickiNalogRepo.Add(nalog);
            Program.korisniciRepo.Add(nalog.Korisnik);
            if(nalog.Korisnik.RadnoMesto != null)
            {
                NaplatnaStanica stanica = (NaplatnaStanica)comboBox2.SelectedItem;
                if (nalog.TipKorisnika == TipKorisnika.VODJA_STANICE)
                    stanica.VodjaStanice = nalog.Korisnik;
                stanica.Radnici.Add(nalog.Korisnik);
            }

            Program.korisnickiNalogRepo.Save();
            Program.korisniciRepo.Save();
            Program.staniceRepo.Save();
            this.Close();
        }
    }
}
