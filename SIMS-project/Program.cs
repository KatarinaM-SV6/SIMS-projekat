using Newtonsoft.Json;
using SIMS_project.Korisnici;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS_project.NaplatneStanice;
using SIMS_project.Uredjaji;

namespace SIMS_project
{
    static class Program
    {
        private static readonly string podaciDir = Path.Combine("..", "..", "Podaci") + Path.DirectorySeparatorChar;
        private static readonly JsonSerializerSettings jsonPodesavanja = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };
        public static NaplatnaStanicaRepository staniceRepo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
        public static KorisnikRepository korisniciRepo = new KorisnikRepository(podaciDir + "korisnici.json", jsonPodesavanja);
        public static KorisnickiNalogRepository kornalogRepo = new KorisnickiNalogRepository(podaciDir + "korisnicki_nalozi.json", jsonPodesavanja);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //generateKorisnici();
            //generateStanice();
            kornalogRepo.Save();
            korisniciRepo.Save();
            staniceRepo.Save();
            Application.Run(new Form1());

        }

        public static void generateStanice()
        {
            List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();
            for (int i = 1; i <= 5; i++)
            {
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(new Mesto("Mesto" + i), new List<NaplatnoMesto>(), "A" + i);
                naplatnaStanica.VodjaStanice = korisniciRepo.GetById(1);
                Korisnik radnik = korisniciRepo.GetById(i - 1);
                radnik.RadnoMesto = naplatnaStanica;
                naplatnaStanica.Radnici.Add(radnik);
                for (int j = 1; j <= 5; j++)
                {
                    NaplatnoMesto naplatnoMesto = new NaplatnoMesto(false, true, new List<Uredjaj> { new Uredjaj("KAMERA"), new Uredjaj("RAMPA") });
                    naplatnaStanica.AddMesto(naplatnoMesto);
                }
                naplatneStanice.Add(naplatnaStanica);
                staniceRepo.Add(naplatnaStanica);
            }
        }

        public static void generateKorisnici()
        {
            korisniciRepo.Add(new Korisnik("Milan", "Milovanovic", new KorisnickiNalog(), new NaplatnaStanica()));
            korisniciRepo.Add(new Korisnik("Jelena", "Ristic", new KorisnickiNalog(), new NaplatnaStanica()));
            korisniciRepo.Add(new Korisnik("Nikola", "Milovanovic", new KorisnickiNalog(), new NaplatnaStanica()));
            korisniciRepo.Add(new Korisnik("Milan", "Krstic", new KorisnickiNalog(), new NaplatnaStanica()));
            korisniciRepo.Add(new Korisnik("Sandra", "Popovic", new KorisnickiNalog(), new NaplatnaStanica()));

            foreach (var k in korisniciRepo.GetAll())
            {
                KorisnickiNalog nalog = new KorisnickiNalog(k.Ime + k.Prezime, "123", TipKorisnika.REFERENT, k);
                kornalogRepo.Add(nalog);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

    }
}
