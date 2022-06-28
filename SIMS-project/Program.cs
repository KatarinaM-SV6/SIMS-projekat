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

namespace SIMS_project
{
    static class Program
    {
        private static readonly string podaciDir = Path.Combine("..", "..", "Podaci") + Path.DirectorySeparatorChar;
        private static readonly JsonSerializerSettings jsonPodesavanja = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.None };
        public static KorisnikRepository korisniciRepo = new KorisnikRepository(podaciDir + "korisnici.json", jsonPodesavanja);
        public static KorisnickiNalogRepository naloziRepo = new KorisnickiNalogRepository(podaciDir + "korisnicki_nalozi.json", jsonPodesavanja);
        public static NaplatnaStanicaRepository staniceRepo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
        public static DojavaOKvaruRepository dojaveRepo = new DojavaOKvaruRepository(podaciDir + "DojaveOKvaru.json", jsonPodesavanja);
        public static DeonicaRepository deoniceRepo = new DeonicaRepository(podaciDir + "Deonice.json", jsonPodesavanja);
        public static KorisnickiNalogRepository kornalogRepo = new KorisnickiNalogRepository(podaciDir + "korisnicki_nalozi.json", jsonPodesavanja);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           /* korisniciRepo.Add(new Korisnik("Milan", "Milovanovic"));
            korisniciRepo.Add(new Korisnik("Jelena", "Ristic"));
            korisniciRepo.Add(new Korisnik("Nikola", "Milovanovic"));
            korisniciRepo.Add(new Korisnik("Milan", "Krstic"));

            foreach (var k in korisniciRepo.GetAll())
            {
                KorisnickiNalog nalog = new KorisnickiNalog(k.Ime + k.Prezime, "123", TipKorisnika.REFERENT, k);
                kornalogRepo.Add(nalog);
                k.KorisnickiNalog = nalog;
            }
            korisniciRepo.Save();
            kornalogRepo.Save(); */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void test()
        {
            List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();
            for (int i = 1; i < 5; i++)
            {
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(new Mesto("Mesto" + i), new List<NaplatnoMesto>(), "A" + i);
                naplatnaStanica.VodjaStanice = korisniciRepo.GetById(1);
                for (int j = 1; j < 5; j++)
                {
                    NaplatnoMesto naplatnoMesto = new NaplatnoMesto(false, true, new List<Uredjaj> { new Uredjaj("KAMERA"), new Uredjaj("RAMPA") });
                    naplatnaStanica.AddMesto(naplatnoMesto);
                }
                naplatneStanice.Add(naplatnaStanica);
                staniceRepo.Add(naplatnaStanica);
            }
            string jsonString = JsonConvert.SerializeObject(naplatneStanice, Formatting.Indented);

            Console.WriteLine(jsonString);
            staniceRepo.Save();
        }

        public static void testDojava ()
        {
            List<DojavaOKvaru> dojave = new List<DojavaOKvaru>();
            Uredjaj u = new Uredjaj(VrstaUredjaja.KAMERA.ToString());
            dojaveRepo.Add(new DojavaOKvaru(DateTime.Now, u, "a", false, false, staniceRepo.GetById(0)));
            dojaveRepo.Add(new DojavaOKvaru(DateTime.Now, u, "b", false, true, staniceRepo.GetById(1)));
            dojaveRepo.Add(new DojavaOKvaru(DateTime.Now, u, "ccc", true, false, staniceRepo.GetById(2)));
            dojaveRepo.Add(new DojavaOKvaru(DateTime.Now, u, "d", false, false, staniceRepo.GetById(3)));
            dojaveRepo.Add(new DojavaOKvaru(DateTime.Now, u, "eee", true, true, staniceRepo.GetById(2)));
            Console.WriteLine(KorisnickiNalogJSONReferenceConverter.Repo == null);
            Console.WriteLine(KorisnikJSONReferenceConverter.Repo == null);
            dojaveRepo.Save();
        }

    }
}
