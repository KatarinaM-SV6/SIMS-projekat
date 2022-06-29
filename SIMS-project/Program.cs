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
using SIMS_project.Uredjaji.DojaveOKvaru;
using SIMS_project.Deonice;
using SIMS_project.Transakcije;
using SIMS_project.Deonice.Cenovnik;

namespace SIMS_project
{
    static class Program
    {
        private static readonly string podaciDir = Path.Combine("..", "..", "Podaci") + Path.DirectorySeparatorChar;

        private static readonly JsonSerializerSettings jsonPodesavanja = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        public static NaplatnaStanicaRepository staniceRepo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
        public static KorisnikRepository korisniciRepo = new KorisnikRepository(podaciDir + "korisnici.json", jsonPodesavanja);
        public static KorisnickiNalogRepository naloziRepo = new KorisnickiNalogRepository(podaciDir + "korisnicki_nalozi.json", jsonPodesavanja);
        public static DojavaOKvaruRepository dojaveRepo = new DojavaOKvaruRepository(podaciDir + "DojaveOKvaru.json", jsonPodesavanja);
        public static DeonicaRepository deoniceRepo = new DeonicaRepository(podaciDir + "Deonice.json", jsonPodesavanja);
        public static CenovnikRepository cenovnikRepo = new CenovnikRepository(podaciDir + "Cenovnici.json", jsonPodesavanja);
        public static TransakcijaRepository transakcijaRepo = new TransakcijaRepository(podaciDir + "Transakcije.json", jsonPodesavanja);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Cenovnik c = cenovnikRepo.GetAll()[0];
            c.KrajVazenja = DateTime.Now.AddDays(2);
            Application.Run(new Login());
            
            transakcijaRepo.Save();
            dojaveRepo.Save();
            staniceRepo.Save();
            korisniciRepo.Save();
            naloziRepo.Save();
            staniceRepo.Save();
        }

        public static void generateStanice()
        {
            List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();
            for (int i = 1; i < 5; i++)
            {
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(new Mesto("Mesto" + i), new List<NaplatnoMesto>(), "A" + i);
                naplatnaStanica.VodjaStanice = i;

                Korisnik radnik = korisniciRepo.GetById(i - 1);
                radnik.RadnoMesto = naplatnaStanica;
                for (int j = 1; j < 5; j++)
                {
                    NaplatnoMesto naplatnoMesto = new NaplatnoMesto(false, true, new List<Uredjaj> { new Uredjaj("KAMERA"), new Uredjaj("RAMPA") });
                    naplatnaStanica.AddMesto(naplatnoMesto);
                }
                staniceRepo.Add(naplatnaStanica);
            }
        }

        public static void generateKorisnici()
        {
            korisniciRepo.Add(new Korisnik("Milan", "Milovanovic"));
            korisniciRepo.Add(new Korisnik("Jelena", "Ristic"));
            korisniciRepo.Add(new Korisnik("Nikola", "Milovanovic"));
            korisniciRepo.Add(new Korisnik("Milan", "Krstic"));
            korisniciRepo.Add(new Korisnik("Sandra", "Popovic"));

            foreach (var k in korisniciRepo.GetAll())
            {
                KorisnickiNalog nalog = new KorisnickiNalog(k.Ime + k.Prezime, "123", TipKorisnika.REFERENT, k);
                naloziRepo.Add(nalog);
            }

        }

    }
}
