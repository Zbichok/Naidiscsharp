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
            double a, b;


            while (true)
            {
                Console.Write("Sisesta toa esimese seina pikkus (m): ");
                string sisend = Console.ReadLine();

                if (double.TryParse(sisend, out a) && a > 0)
                    break;

                Console.WriteLine("Viga: sisesta positiivne number!");
            }

            while (true)
            {
                Console.Write("Sisesta toa teise seina pikkus (m): ");
                string sisend = Console.ReadLine();

                if (double.TryParse(sisend, out b) && b > 0)
                    break;

                Console.WriteLine("Viga: sisesta positiivne number!");
            }

            double pindala = a * b;
            Console.WriteLine("Põranda pindala on " + pindala + " m2.");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string soov = Console.ReadLine().ToLower();

            if (soov == "jah")
            {
                double ruutmeetriHind;
                while (true)
                {
                    Console.Write("Sisesta ruutmeetri hind (€/m2): ");
                    string sisend = Console.ReadLine();

                    if (double.TryParse(sisend, out ruutmeetriHind) && ruutmeetriHind > 0)
                        break;

                    Console.WriteLine("Viga: sisesta positiivne number!");
                }

                double hind = pindala * ruutmeetriHind;
                Console.WriteLine($"Põranda vahetamise hind on {hind:F2} euro.");

            }
            else
            {
                Console.WriteLine("Remonti ei arvutata.");
            }
        }

        public static void soodustus()
        {
            double soodushind;

            while (true)
            {
                Console.Write("Sisesta 30% soodushind: ");
                string sisend = Console.ReadLine();

                if (double.TryParse(sisend, out soodushind) && soodushind > 0)
                    break;

                Console.WriteLine("Viga: sisesta positiivne number!");
            }

            double algneHind = soodushind * 100 / 30;

            Console.WriteLine("Alghind oli umbes " + algneHind.ToString("F2") + " euro.");
        }
        public static void temperatuur()
        {
            double temp;

            while (true)
            {
                Console.Write("Sisesta temperatuur (°C): ");
                string sisend = Console.ReadLine();

                if (double.TryParse(sisend, out temp))
                    break;

                Console.WriteLine("Viga: sisesta korrektne arv!");
            }

            if (temp > 18)
                Console.WriteLine("Temperatuur on üle 18 kraadi.");
            else
                Console.WriteLine("Temperatuur ei ole üle 18 kraadi.");
        }
        public static void inimPikkus()
        {
            int pikkus;


            while (true)
            {
                Console.Write("Sisesta pikkus (cm): ");
                string sisend = Console.ReadLine();

                if (int.TryParse(sisend, out pikkus) && pikkus > 0)
                    break;

                Console.WriteLine("Viga: sisesta positiivne täisarv!");
            }

            if (pikkus < 163)
            {
                Console.WriteLine("Sa oled lühikest kasvu");
            }
            else if (pikkus < 185)
            {
                Console.WriteLine("Sa oled keskmist kasvu");
            }
            else
            {
                Console.WriteLine("Sa oled pikk");
            }
        }
        public static void inimPikkusJaSugu()
        {
            string sugu;
            while (true)
            {
                Console.Write("Sisesta sugu (m/n): ");
                sugu = Console.ReadLine().Trim().ToLower();

                if (sugu == "m" || sugu == "n")
                    break;

                Console.WriteLine("Viga: sisesta ainult 'm' või 'n'!");
            }

            int pikkus;


            while (true)
            {
                Console.Write("Sisesta pikkus (cm): ");
                string sisend = Console.ReadLine();

                if (int.TryParse(sisend, out pikkus) && pikkus > 0)
                    break;

                Console.WriteLine("Viga: sisesta positiivne täisarv!");
            }

            if (sugu == "m")
            {
                if (pikkus < 170)
                    Console.WriteLine("Sa oled lühikest kasvu.");
                else if (pikkus <= 190)
                    Console.WriteLine("Sa oled keskmist kasvu.");
                else
                    Console.WriteLine("Sa oled pikk.");
            }

            else
            {
                if (pikkus < 160)
                    Console.WriteLine("Sa oled lühikest kasvu.");
                else if (pikkus <= 180)
                    Console.WriteLine("Sa oled keskmist kasvu.");
                else
                    Console.WriteLine("Sa oled pikk.");
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
            string piim = Console.ReadLine().Trim().ToLower();

            if (piim == "jah")
            {
                summa += hindPiim;
                ostud += "piim ";
            }

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            string sai = Console.ReadLine().Trim().ToLower();

            if (sai == "jah")
            {
                summa += hindSai;
                ostud += "sai ";
            }

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            string leib = Console.ReadLine().Trim().ToLower();

            if (leib == "jah")
            {
                summa += hindLeib;
                ostud += "leib ";
            }

            if (string.IsNullOrWhiteSpace(ostud))
                Console.WriteLine("Sa ei ostnud midagi.");
            else
                Console.WriteLine("Ostetud: " + ostud + "Kokku: " + summa.ToString("F2") + " euro.");
        }
    }
}


