using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp
{
    internal class osa4funktsioon
    {
    public static void LisaLemmikToit()
        {
            Console.Write("Sisesta oma lemmik Itaalia toit: ");
            string toit = Console.ReadLine();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true)) // true = lisab lõppu
                {
                    sw.WriteLine(toit);
                }
                Console.WriteLine("Toit on faili edukalt lisatud!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Faili kirjutamisel tekkis viga: " + ex.Message);
            }
        }

 
        public static void Kuvamenyy()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string sisu = sr.ReadToEnd();
                    Console.WriteLine("Menüü sisu:\n" + sisu);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Faili lugemisel tekkis viga: " + ex.Message);
            }
        }


        public static List<string> MuudaKoostisosi()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
            List<string> koostisosad = new List<string>();

            try
            {
                string[] read = File.ReadAllLines(path);
                koostisosad.AddRange(read);

                if (koostisosad.Count > 0)
                    koostisosad[0] = "Kvaliteetne oliiviõli";

                koostisosad.Remove("Ketšup");

                Console.WriteLine("Uuenenud koostisosad:");
                foreach (string koostis in koostisosad)
                {
                    Console.WriteLine(koostis);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Faili lugemisel tekkis viga: " + ex.Message);
            }

            return koostisosad;
        }

        public static void OtsiKoostisosa(List<string> koostisosad)
        {
            Console.Write("Sisesta otsitav koostisosa: ");
            string otsitav = Console.ReadLine();

            if (koostisosad.Contains(otsitav))
                Console.WriteLine("Koostisosa on olemas!");
            else
                Console.WriteLine("Seda koostisosa meil retseptis ei ole.");
        }
        public static void SalvestaKoostisosa(List<string> koostisosad)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");

            try
            {
                File.WriteAllLines(path, koostisosad);
                Console.WriteLine("Uus retsept on edukalt faili salvestatud!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Faili salvestamisel tekkis viga: " + ex.Message);
            }
        }
    }
}
