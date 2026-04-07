using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Naidiscsharp
{
    internal class Osa5StartPage
    {
        public static void Osa5Main()
        {
            Console.WriteLine("Osa 5 - OOP");
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1 - KaloriKalkulaator");
            Console.WriteLine("2 - MaardikTest");
            Console.WriteLine("3 - Loom klass");
            Console.WriteLine("4 - Pank klass");
            Console.WriteLine("5 - Raamatukogu klass");
            Console.WriteLine("6 - Lemmikloomad klass");
            Console.WriteLine("7 - ValuutaKalkulaator");
            Console.WriteLine("8 - array_naide");
            Console.WriteLine("9 - Tuple");
            Console.WriteLine("10 - LinkedList");
            Console.WriteLine("11 - sõnatlik");
            Console.WriteLine("0 - välja");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    osa5funktsioon.KaloriKalkulaator();
                    break;
                case "2":
                    osa5funktsioon.MaardikTest();
                    break;
                case "3":
                    osa5funktsioon.Opilased();
                    break;
                case "4":
                    osa5funktsioon.Filmid();
                    break;
                case "5":
                    osa5funktsioon.MassiivStatistika();
                    break;
                case "6":
                    osa5funktsioon.Lemmikloomad();
                    break;
                case "7":
                    osa5funktsioon.ValuutaKalkulaator();
                    break;
                case "8":
                    osa5funktsioon.array_naide();
                    break;
                case "9":
                    osa5funktsioon.Tuple();
                    break;
                case "10":
                    osa5funktsioon.LinkedList();
                    break;
                case "11":
                    osa5funktsioon.sonatlik();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Vale valik. Palun vali 1-11 või 0.");
                    break;
            }
        }
    }
}