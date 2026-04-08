using Naidiscsharp.Itaaliatoit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Naidiscsharp
{
    internal class osa4startpage
    {
        public static void Osa4Main()
        {
            Console.WriteLine("Osa 4 - Failid");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - tekstisisestamine");
            Console.WriteLine("2 - Tekstilugemine");
            Console.WriteLine("3 - Ridade_lugemine");
            Console.WriteLine("4 - listi_muutmine");
            Console.WriteLine("5 - Otsing");
            Console.WriteLine("6 - Listisalvestamine");
            Console.WriteLine("------------------------------");
            Console.WriteLine("7 - ItaliaToit ");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    osa4Faili.tekstisisestamine();
                    break;
                case "2":
                    osa4Faili.Tekstilugemine();
                    break;
                case "3":
                    Console.WriteLine("Sisesta faili nimi: ");
                    string file = Console.ReadLine();
                    osa4Faili.Ridade_lugemine(file);
                    break;
                case "4":
                    osa4Faili.listi_muutmine("test.txt");
                    break;
                case "5":
                    osa4Faili.Otsing("test.txt");
                    break;
                case "6":
                    osa4Faili.Listisalvestamine("test.txt");
                    break;
                case "7":
                    ItaaliaMain.MainItalia(new string[0]);
                    break;
                default:
                    Console.WriteLine("Vale valik. Palun vali 1-7.");
                    break;
            }
        }
    }
}