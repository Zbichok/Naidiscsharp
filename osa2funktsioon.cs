using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp
{
    internal class osa2funktsioon
    {
        public static void Juku()
        {
            string nimi;


            while (true)
            {
                Console.Write("Mis on sinu nimi: ");
                nimi = Console.ReadLine();

                if (!string.IsNullOrEmpty(nimi) && nimi.All(char.IsLetter))
                    break;

                Console.WriteLine("Viga: sisesta ainult tähed!");
            }

            if (nimi.ToLower() != "juku")
            {
                Console.WriteLine($"Tere {nimi}, ma olen hõivatud");
                return;
            }

            int vanus;


            while (true)
            {
                Console.Write("Kui vana sa oled?: ");
                string sisend = Console.ReadLine();

                if (int.TryParse(sisend, out vanus) && vanus > 0)
                    break;

                Console.WriteLine("Viga: sisesta ainult positiivne arv!");
            }

            if (vanus >= 100)
            {
                Console.WriteLine("Viga: vanus peab olema < 100!");
                return;
            }

            string pilet;

            if (vanus < 6)
                pilet = "Tasuta";
            else if (vanus <= 14)
                pilet = "Lastepilet";
            else if (vanus <= 65)
                pilet = "Täispilet";
            else
                pilet = "Sooduspilet";

            Console.WriteLine($"Tere Juku, lähme kinno! Sulle on {pilet}");
        }
        public static void Pinginaabrid()
        {
            string nimi1, nimi2;


            while (true)
            {
                Console.Write("Sisesta esimene nimi: ");
                nimi1 = Console.ReadLine();

                if (!string.IsNullOrEmpty(nimi1) && nimi1.All(char.IsLetter))
                    break;

                Console.WriteLine("Viga: sisesta ainult tähed!");
            }


            while (true)
            {
                Console.Write("Sisesta teine nimi: ");
                nimi2 = Console.ReadLine();

                if (!string.IsNullOrEmpty(nimi2) && nimi2.All(char.IsLetter))
                    break;

                Console.WriteLine("Viga: sisesta ainult tähed!");
            }

            Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid.");
        }

        
        public static void RemondiKalk()
        {
            Console.Write("Sisesta toa esimese seina pikkus (m): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta toa teise seina pikkus (m): ");
            double b = double.Parse(Console.ReadLine());

            double pindala = a * b;
            Console.WriteLine("Põranda pindala on " + pindala + " m2.");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string soov = Console.ReadLine();

            if (soov == "jah")
            {
                Console.Write("Sisesta ruutmeetri hind (€/m2): ");
                double ruutmeetriHind = double.Parse(Console.ReadLine());

                double hind = pindala * ruutmeetriHind;
                Console.WriteLine("Põranda vahetamise hind on " + hind + " euro.");
            }
            else
            {
                Console.WriteLine("Remonti ei arvutata.");
            }
        }
        public static void soodustus()
        {
            Console.WriteLine("Sisesta 30% soodushind");
            double soodushind = double.Parse(Console.ReadLine());

            double algneHind = soodushind * 100 / 30;
            Console.WriteLine("Alghind oli umbes " + algneHind.ToString("F2") + "euro.");
        }
        public static void temperatuur()
        {
            Console.Write("Sisesta temperatuur (°C): ");
            double temp = double.Parse(Console.ReadLine());

            if (temp > 18)
                Console.WriteLine("Temperatuur on üle 18 kraadi.");
            else
                Console.WriteLine("Temperatuur ei ole üle 18 kraadi.");
        }
        public static void inimPikkus()
        {
            Console.WriteLine("Sisesta pikkus ");
            int pikkus = int.Parse(Console.ReadLine());

            if (pikkus < 163)
            {
                Console.WriteLine("Sa oled lühikest pikkust ");
            }
            else if (pikkus < 185)
            {
                Console.WriteLine(" Sa oled keskmist pikkust ");
            }
            else
            {
                Console.WriteLine("Sa oled pikk");
            }
        }
        public static void inimPikkusJaSugu()
        {
            Console.Write("Sisesta sugu (m/n): ");
            string sugu = Console.ReadLine().Trim().ToLower();

            Console.Write("Sisesta pikkus (cm): ");
            int pikkus = int.Parse(Console.ReadLine());

            if (sugu == "m")
            {
                if (pikkus < 170) Console.WriteLine("Sa oled lühikest pikkust.");
                else if (pikkus <= 190) Console.WriteLine("Sa oled keskmist pikkust.");
                else Console.WriteLine("Sa oled pikk.");
            }
            else if (sugu == "n")
            {
                if (pikkus < 160) Console.WriteLine("Sa oled lühikest pikkust.");
                else if (pikkus <= 180) Console.WriteLine("Sa oled keskmist pikkust.");
                else Console.WriteLine("Sa oled pikk.");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public static void poesOstetudAsjad()
        {
            double hindPiim = 1.20;
            double hindSai = 0.90;
            double hindLeib = 1.50;

            double summa = 0;
            string ostud = "";

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            string piim = Console.ReadLine();
            if (piim == "jah")
            {
                summa += hindPiim;
                ostud += "piim ";
            }

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            string sai = Console.ReadLine();
            if (sai == "jah")
            {
                summa += hindSai;
                ostud += "sai ";
            }

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            string leib = Console.ReadLine();
            if (leib == "jah")
            {
                summa += hindLeib;
                ostud += "leib ";
            }

            if (ostud == "")
                Console.WriteLine("Sa ei ostnud midagi.");
            else
                Console.WriteLine("Ostetud: " + ostud + "Kokku: " + summa + " euro.");
        }
    }
}
