using SIMS_project.Deonice;
using SIMS_project.Korisnici;
using SIMS_project.NaplatneStanice;
using SIMS_project.Transakcije;
using SIMS_project.Uredjaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_project.view.referentView
{
    public partial class NaplataForma : Form
    {
        private Transakcija transakcija;
        private readonly KorisnickiNalog ulogovaniReferent;
        private readonly NaplatnoMesto naplatnoMesto;
        private Deonica deonica;

        public NaplataForma(KorisnickiNalog referent, NaplatnoMesto mesto)
        {
            ulogovaniReferent = referent;
            naplatnoMesto = mesto;
            InitializeComponent();
            lblMesto.Text = "Naplatno mesto sa rednim brojem " + naplatnoMesto.RedniBroj.ToString();
            btnZavrsi.Enabled = false;
            DisplayUredjajiTableData();
            SetTbTablice();
            FillCBTip();
        }

        private void FillCBTip()
        {
            foreach (TipVozila tip in Enum.GetValues(typeof(Transakcije.TipVozila)))
            {
                cbTip.Items.Add(tip.ToString());
                cbTip.SelectedItem = tip.ToString();   
            }
        }

        private void DisplayUredjajiTableData()
        {
            foreach (Uredjaj u in naplatnoMesto.Uredjaji)
            {
                dataGridViewUredjaji.Rows.Add(u.VrstaUredjaja.ToString(), u.UFunkciji);
            }
        }

        private void SetTbTablice()
        {
            string tablice = Program.transakcijaRepo.GetRandomTablice();
            if (tablice != "") tbTablice.Text = tablice;
            else
            {
                MessageBox.Show("Nema vozila na naplatnom mestu.");
                this.Dispose();
            }

        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                Transakcija t = Program.transakcijaRepo.GetByIdZapocete(int.Parse(tbId.Text));
                transakcija = t;
                FillFields();
            }
            catch
            {
                MessageBox.Show("Nije pronadjena transakcija sa zadatim ID.");
            }
        }

        private void FillFields()
        {
            btnZavrsi.Enabled = true;
            NaplatnaStanica stanicaUlaska = Program.staniceRepo.PronadjiPoNaplatnomMestu(transakcija.MestoUlaska);
            NaplatnaStanica stanicaIzlaska = ulogovaniReferent.Korisnik.RadnoMesto;

            if (stanicaUlaska == null || stanicaIzlaska == null)
            {
                MessageBox.Show("Greska. Nepostojeca stanica ulaska/izlaska.");
                return;
            }

            deonica = Program.deoniceRepo.PronadjiPoStanicama(stanicaUlaska, stanicaIzlaska);
            if (deonica == null)
            {
                MessageBox.Show("Greska. Nepostojeca deonica.");
                return;
            }

            lblTablice.Text = transakcija.BrojTablica;
            tbMestoUlaska.Text = stanicaUlaska.Mesto.Naziv + " " + stanicaUlaska.NazivAutoputa + " " + transakcija.MestoUlaska.RedniBroj;
            tbVremeUlaska.Text = transakcija.VremeUlaska.ToString("dd.MM.yyyy. HH:mm");
            tbBrzina.Text = IzracunajBrzinu(transakcija.VremeUlaska, deonica.Kilometraza).ToString();
        }
        
        private int IzracunajBrzinu(DateTime vremeUlaska, int kilometraza)
        {
            return (int) (kilometraza / (DateTime.Now - vremeUlaska).TotalHours);
        }
        
        private void CbTip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipVozila tip = (TipVozila)Enum.Parse(typeof(TipVozila), cbTip.SelectedItem.ToString());
            transakcija.TipVozila = tip;
            tbIznos.Text = Program.cenovnikRepo.GetRSDCena(deonica, tip).ToString();
        }
        
        private void TbUplacenIznos_Leave(object sender, EventArgs e)
        {
            int uplacenIznos = CheckFieldUplacenIznos();
            if (uplacenIznos < 0) return;
            IzracunajKusur();
        }

        private int CheckFieldUplacenIznos()
        {
            try
            {
                int uplacenIznos = int.Parse(tbUplacenIznos.Text);
                if (uplacenIznos > 0 && uplacenIznos >= int.Parse(tbIznos.Text)) return uplacenIznos;
                else
                {
                    MessageBox.Show("Uplacen iznos je manji od iznosa putarine.\nNije moguce zavrsiti naplatu.");
                    return -1;
                }
            } catch
            {
                MessageBox.Show("Uplacen iznos je unet u neispravnom formatu.");
                return -1;
            }
        }


        private void IzracunajKusur()
        {
            tbKusur.Text = (int.Parse(tbUplacenIznos.Text) - int.Parse(tbIznos.Text)).ToString();
        }

        private void FinalizujTransakciju()
        {
            transakcija.VremeIzlaska = DateTime.Now;
            transakcija.MestoIzlaska = naplatnoMesto;
            transakcija.StanicaIzlaska = ulogovaniReferent.Korisnik.RadnoMesto; 
            transakcija.Iznos = int.Parse(tbIznos.Text);
            Program.transakcijaRepo.ZapoceteTransakcije.Remove(transakcija);
            Program.transakcijaRepo.Add(transakcija);
        }


        private void BtnZavrsi_Click(object sender, EventArgs e)
        {
            if (CheckFieldUplacenIznos() < 0) return;
            FinalizujTransakciju();
            MessageBox.Show("Transakcija uspesno izvrsena.");
            this.Dispose();
        }

    }
}
