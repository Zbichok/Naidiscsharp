using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Naidiscsharp
{
    internal class osa3funktsioon
    {
        public static void JuhuslkiudRuudud()
        {
            Random rnd = new Random();
            int min = 1;
            int max = 10;

            int N = rnd.Next(min, max + 1);
            int M = rnd.Next(min, max + 1);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);


            for (int i = start; i <= end; i++)
            {
                int ruut = i * i;
                Console.WriteLine($"{i} - {ruut}");
            }

        }

        public static void ostaElevantAra()
        {
            while (true)
            {
                Console.WriteLine("Osta elevant ära");
                string vastus = Console.ReadLine().ToLower();
                if (vastus == "jah")
                {
                    Console.WriteLine("Oled ostnud elevandi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kõik nii rakivad, aga Osta elevant ära");
                }

            }
        }
        public static void arvumang()
        {
            bool uuesti = true; 

            while (uuesti) 
            {
                Random rnd = new Random();
                int arv = rnd.Next(1, 101);
                int katse = 0;

                Console.WriteLine("\nArvuti valis numbri 1–100. Sul on 5 katset.");

                while (katse < 5)
                {
                    int arva;
                    while (true) 
                    {
                        Console.Write("Arva ära number 1–100: ");
                        string sisend = Console.ReadLine();

                        if (int.TryParse(sisend, out arva) && arva >= 1 && arva <= 100)
                            break;

                        Console.WriteLine("Viga: sisesta number vahemikus 1–100!");
                    }

                    katse++;

                    if (arva > arv)
                    {
                        Console.WriteLine("Sinu number on väiksem");
                    }
                    else if (arva < arv)
                    {
                        Console.WriteLine("Sinu number on suurem");
                    }
                    else
                    {
                        Console.WriteLine($"Õige! Arvasid ära {katse}. katsel.");
                        break;
                    }
                }

               
                if (katse == 5 && arv != katse)
                {
                    Console.WriteLine($"Mäng läbi! Arv oli {arv}.");
                }

                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                string vastus = Console.ReadLine().Trim().ToLower();
                uuesti = (vastus == "jah" || vastus == "j");
            }
        }

        public static void SuurimNeliarv()
        {
            int[] arvud = new int[4];

            Console.WriteLine("Sisesta 4 ühekohalist arvu (0–9):");

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Sisesta {i + 1}. arv: ");
                    string sisend = Console.ReadLine();

                    if (int.TryParse(sisend, out int arv) && arv >= 0 && arv <= 9)
                    {
                        arvud[i] = arv;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Viga: sisesta ühekohaline number vahemikus 0–9!");
                    }
                }
            }

            Array.Sort(arvud);
            Array.Reverse(arvud);

            int maksimaalne = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];

            Console.WriteLine($"Suurim võimalik neljakohaline arv on: {maksimaalne}");
        }
        public static void Korrutustabel(int read, int veerud)
        {
            int[,] tabel = new int[read, veerud];

            for (int i = 0; i < read; i++)
            {
                for (int j = 0; j < veerud; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void Opilastegmangimine()
        {
            string[] nimed = new string[10] { "Andres", "Mari", "Aadu", "Peeter", "Anna", "Liis", "Airi", "Jaan", "Anu", "Tiit" };
            nimed[2] = "Kati";
            nimed[5] = "Mati";
            Console.WriteLine("A-ga algavad tervitused (while):");
            int nr = 0;
            while (nr < nimed.Length)
            {
                if (nimed[nr].StartsWith("A"))
                {
                    Console.WriteLine("Tere, " + nimed[nr]);
                }
                nr = nr + 1;
            }
            Console.WriteLine("Kõik nimed ja indeksid (for):");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(i + " : " + nimed[i]);
            }
            Console.WriteLine("Nimed väikeste tähtedena (foreach):");
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }
            Console.WriteLine("Tervitab kuni 'Mati' (do-while):");
            int k = 0;
            do
            {
                Console.WriteLine("Tere, " + nimed[k]);
                if (nimed[k] == "Mati")
                {
                    break;
                }
                k = k + 1;
            } while (k < nimed.Length);

        }
        public static void ArvudeRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine("Ruudud (for):");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine(arvud[i] + " -> " + (arvud[i] * arvud[i]));
            }
            Console.WriteLine("Kahekordsed (foreach):");
            foreach (int a in arvud)
            {
                Console.WriteLine(a + " -> " + (a * 2));
            }
            Console.WriteLine("Jagub 3-ga (while loendus):");
            int nr = 0;
            int loendur = 0;

            while (nr < arvud.Length)
            {
                if (arvud[nr] % 3 == 0)
                {
                    loendur = loendur + 1;
                }
                nr = nr + 1;
            }

            Console.WriteLine("Kogus: " + loendur);
        }
        public static void PosJaNeg()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int pos = 0;
            int neg = 0;
            int nul = 0;

            foreach (int a in arvud)
            {
                if (a > 0)
                    pos = pos + 1;
                else if (a < 0)
                    neg = neg + 1;
                else
                    nul = nul + 1;
            }

            Console.WriteLine("Positiivseid: " + pos);
            Console.WriteLine("Negatiivseid: " + neg);
            Console.WriteLine("Nulle: " + nul);
        }
        public static void KeskSuuremad()
        {
            Random r = new Random();
            int[] arvud = new int[15];

            int summa = 0;
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = r.Next(1, 101);
                summa = summa + arvud[i];
            }

            double keskmine = (double)summa / arvud.Length;

            Console.WriteLine("Keskmine: " + keskmine);
            Console.WriteLine("\nKeskmisest suuremad:");
            foreach (int a in arvud)
            {
                if (a > keskmine)
                    Console.WriteLine(a);
            }
            Console.WriteLine("\nDo-while kuni arv < 10:");
            int nr = 0;
            do
            {
                Console.WriteLine(arvud[nr]);
                if (arvud[nr] < 10)
                    break;

                nr = nr + 1;

            } while (nr < arvud.Length);

        }
        public static void KoigeSuuremaOtsing()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0];
            int maxIndeks = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i];
                    maxIndeks = i;
                }
            }

            Console.WriteLine("Suurim arv: " + max);
            Console.WriteLine("Indeks: " + maxIndeks);

        }
        public static void PaarisjaPaaritu()
        {
            Random r = new Random();
            List<int> arvud = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                arvud.Add(r.Next(1, 101));
            }
            int paarisSumma = 0;
            foreach (int a in arvud)
            {
                if (a % 2 == 0)
                    paarisSumma = paarisSumma + a;
            }
            int paarituSumma = 0;
            int paarituKogus = 0;

            for (int i = 0; i < arvud.Count; i++)
            {
                if (arvud[i] % 2 != 0)
                {
                    paarituSumma = paarituSumma + arvud[i];
                    paarituKogus = paarituKogus + 1;
                }
            }

            double paarituKeskmine = 0;
            if (paarituKogus != 0)
                paarituKeskmine = (double)paarituSumma / paarituKogus;
            int nr = 0;
            int ule50 = 0;

            while (nr < arvud.Count)
            {
                if (arvud[nr] > 50)
                    ule50 = ule50 + 1;

                nr = nr + 1;
            }

            Console.WriteLine("Paarisarvude summa: " + paarisSumma);
            Console.WriteLine("Paaritute keskmine: " + paarituKeskmine);
            Console.WriteLine(">50 arvude kogus: " + ule50);
        }
    }
}
