using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SIMS_project.NaplatneStanice;
using SIMS_project.Uredjaji;

namespace SIMS_project
{
    static class Program
    {
        private static readonly string podaciDir = Path.Combine("..", "..", "Podaci") + Path.DirectorySeparatorChar;
        private static readonly JsonSerializerSettings jsonPodesavanja = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.None };
        public static NaplatnaStanicaRepository staniceRepo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //test();
            Application.Run(new Form1());
        }

        public static void test()
        {
            NaplatnaStanicaRepository repo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
            List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();
            for (int i = 1; i < 5; i++)
            {
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(new Mesto("Mesto" + i), new List<NaplatnoMesto>(), "A" + i);
                for (int j = 1; j < 10; j++)
                {
                    NaplatnoMesto naplatnoMesto = new NaplatnoMesto(j, false, true, j, new List<Uredjaj> { new Uredjaj("KAMERA"), new Uredjaj("RAMPA") });
                    naplatnaStanica.NaplatnaMesta.Add(naplatnoMesto);
                }
                naplatneStanice.Add(naplatnaStanica);
                repo.Add(naplatnaStanica);
            }
            string jsonString = JsonConvert.SerializeObject(naplatneStanice, Formatting.Indented);

            Console.WriteLine(jsonString);
            repo.Save();
        } 
    }
}
