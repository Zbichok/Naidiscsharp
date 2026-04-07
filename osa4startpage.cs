using Naidiscsharp.Itaaliatoit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp
{
    internal class Osa4StartPAge
    {
        public static void Osa4Main()
        {
            Console.WriteLine("Osa 4 - Failid");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - LisaLemmikToit");
            Console.WriteLine("2 - Kuvamenyy");
            Console.WriteLine("3 - MuudaKoostisosi");
            Console.WriteLine("4 - OtsiKoostisosa");
            Console.WriteLine("5 - SalvestaKoostisosa");
            Console.WriteLine("======================");
            Console.WriteLine("6 - MainItalia");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    osa4funktsioon.LisaLemmikToit();
                    break;
                case "2":
                    osa4funktsioon.Kuvamenyy();
                    break;
                case "3":
                    {
                        List<string> list = osa4funktsioon.MuudaKoostisosi();
                        break;
                    }
                case "4":
                    {
                        List<string> list = osa4funktsioon.MuudaKoostisosi(); 
                        osa4funktsioon.OtsiKoostisosa(list);
                        break;
                    }
                case "5":
                    {
                        List<string> list = osa4funktsioon.MuudaKoostisosi(); 
                        osa4funktsioon.SalvestaKoostisosa(list);
                        break;
                    }
                case "6":
                    ItaaliaMain.MainItalia(new string[0]);
                    break;
                default:
                    Console.WriteLine("Vale valik. Palun vali 1-7.");
                    break;
            }
        }
    }
}

