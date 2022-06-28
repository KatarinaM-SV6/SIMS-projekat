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
            _nalog = nalog;
            comboBox1.DataSource = Enum.GetValues(typeof(TipKorisnika));
            comboBox2.DataSource = Program.staniceRepo.GetAll();
            load();
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
        private void button1_Click(object sender, EventArgs e)
        {
            KorisnickiNalog nalog = Program.korisnickiNalogRepo.GetById(_nalog.Id);
            if (nalog != null)
            {
                string korisnickoIme = textBox1.Text;
                if (Program.korisnickiNalogRepo.GetByUsername(korisnickoIme).Count() != 0)
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
            
                Program.korisnickiNalogRepo.Save();
                Program.korisniciRepo.Save();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KorisnickiNalog nalog = Program.korisnickiNalogRepo.GetById(_nalog.Id);
            if (nalog == null)
            {
                nalog = new KorisnickiNalog();
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
                nalog.Korisnik.RadnoMesto = (NaplatnaStanica)comboBox2.SelectedItem;
                
                Program.korisnickiNalogRepo.Add(nalog);
                Program.korisniciRepo.Add(nalog.Korisnik);

                Program.korisnickiNalogRepo.Save();
                Program.korisniciRepo.Save();
            }
            else
            {
                MessageBox.Show("Korisnicki nalog vec postoji");
            }
        }
    }
}
