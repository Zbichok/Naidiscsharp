using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp
{
    internal class osa2startpage
    {
        public static void Osa2Main()
        {
            Console.WriteLine("Osa 2 - Funktsioonid");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - Juku");
            Console.WriteLine("2 - Pinginaabrid");
            Console.WriteLine("3 - RemondiKalk");
            Console.WriteLine("4 - Soodustus");
            Console.WriteLine("5 - Temperatuur");
            Console.WriteLine("6 - InimPikkus");
            Console.WriteLine("7 - InimPikkusJaSugu");
            Console.WriteLine("8 - PoesOstetudAsjad");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    osa2funktsioon.Juku();
                    break;
                case "2":
                    osa2funktsioon.Pinginaabrid();
                    break;
                case "3":
                    osa2funktsioon.RemondiKalk();
                    break;
                case "4":
                    osa2funktsioon.soodustus();
                    break;
                case "5":
                    osa2funktsioon.temperatuur();
                    break;
                case "6":
                    osa2funktsioon.inimPikkus();
                    break;
                case "7":
                    osa2funktsioon.inimPikkusJaSugu();
                    break;
                case "8":
                    osa2funktsioon.poesOstetudAsjad();
                    break;
                default:
                    Console.WriteLine("Vale valik. Palun vali 1-8.");
                    break;
            }
        }
    }
}

