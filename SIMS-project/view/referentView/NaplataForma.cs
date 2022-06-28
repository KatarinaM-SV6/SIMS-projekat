using SIMS_project.Transakcije;
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

        public NaplataForma()
        {
            InitializeComponent();
            btnZavrsi.Enabled = false;
            // Postavi broj tablica pristiglog vozila
            FillCBTip();
            
        }

        private void FillCBTip()
        {
            foreach (string tip in Enum.GetValues(typeof(Transakcije.TipVozila)))
            {
                cbTip.Items.Add(tip);
                cbTip.SelectedItem = tip;   
            }
        }

        private void FillFields()
        {
            /*
            btnZavrsi.Enabled = true;
            stanicaUlaska = NaplatnaStanicaController.pronadjiStanicu(t.MestoUlaska);
            stanicaIzlaska = NaplatnaStanicaController.pronadjiStanicu(trenutnoMesto);
            deonica = DeonicaController.pronadjiDeonicu(stanicaUlaska, stanicaIzlaska);

            lblTablice.Text = t.BrojTablica;
            tbMestoUlaska.Text = stanicaUlaska.Naziv + " " + t.MestoUlaska.RedniBroj;
            tbVremeUlaska.Text = t.VremeUlaska.ToString();
            tbBrzina.Text = izracunajBrzinu(t.VremeUlaska, deonica.Kilometraza);
            */
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
            } catch (Exception e)
            {
                MessageBox.Show("Uplacen iznos je unet u neispravnom formatu.");
                return -1;
            }
        }

        private int IzracunajBrzinu(DateTime vremeUlaska, int kilometraza)
        {
            return (int) (kilometraza / (DateTime.Now - vremeUlaska).TotalHours);
        }

        private void IzracunajKusur()
        {
            tbKusur.Text = (int.Parse(tbUplacenIznos.Text) - int.Parse(tbIznos.Text)).ToString();
        }

        private void FinalizujTransakciju()
        {
            transakcija.BrojTablica = tbTablice.Text;
            transakcija.VremeIzlaska = DateTime.Now;
            //transakcija.MestoIzlaska = trenutnoMesto;
            transakcija.Iznos = int.Parse(tbIznos.Text);
        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            /* Transakcija t = TransakcijaRepo.getById(int.Parse(tbId.Text));
            if (t == null) MessageBox.Show("Nije pronadjena transakcija sa datim ID.\nPonovo pokusajte unos.");
            else
            {
                transakcija = t;
                FillFields();
            } */
        }

        private void CbTip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*TipVozila tip = (TipVozila)Enum.Parse(typeof(TipVozila), cbTip.SelectedItem.ToString());
            transakcija.tip = tip;
            tbIznos.Text = DeonicaController.dobaviCenu(deonica, tip).ToString();
            */
        }

        private void BtnZavrsi_Click(object sender, EventArgs e)
        {
            if (CheckFieldUplacenIznos() < 0) return;
            FinalizujTransakciju();
        }

        private void TbUplacenIznos_Leave(object sender, EventArgs e)
        {
            int uplacenIznos = CheckFieldUplacenIznos();
            if (uplacenIznos < 0) return;
            IzracunajKusur();
        }
    }
}
