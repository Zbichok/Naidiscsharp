using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp
{
    internal class osa3startpage
    {
        public static void Osa3Main()
        {
            Console.WriteLine("Osa 3 - Andmetüübid ja algoritmid");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - JuhuslkiudRuudud");
            Console.WriteLine("2 - ostaElevantAra ");
            Console.WriteLine("3 - arvumang");
            Console.WriteLine("4 - SuurimNeliarv");
            Console.WriteLine("5 - Korrutustabel");
            Console.WriteLine("6 - Opilastegmangimine");
            Console.WriteLine("7 - ArvudeRuudud");
            Console.WriteLine("8 - PosJaNeg");
            Console.WriteLine("9 - KeskSuuremad");
            Console.WriteLine("10 - KoigeSuuremaOtsing");
            Console.WriteLine("11 - PaarisjaPaaritu");
            Console.WriteLine("12 - arvuAnaluus ");
            Console.WriteLine("13 - SõnadePikkus");

            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    osa3funktsioon.JuhuslkiudRuudud();
                    break;
                case "2":
                    osa3funktsioon.ostaElevantAra();
                    break;
                case "3":
                    osa3funktsioon.arvumang();
                    break;
                case "4":
                    osa3funktsioon.SuurimNeliarv();
                    break;
                case "5":

                    break;
                case "6":
                    osa3funktsioon.Opilastegmangimine();
                    break;
                case "7":
                    osa3funktsioon.ArvudeRuudud();
                    break;
                case "8":
                    osa3funktsioon.PosJaNeg();
                    break;
                case "9":
                    osa3funktsioon.KeskSuuremad();
                    break;
                case "10":
                    osa3funktsioon.KoigeSuuremaOtsing();
                    break;
                case "11":
                    osa3funktsioon.PaarisjaPaaritu();
                    break;
                case "12":
                    osa3funktsioon.arvuAnaluus();
                    break;
                default:
                    Console.WriteLine("Vale valik. Palun vali 1-13.");
                    break;

            }
        }

    }
}


