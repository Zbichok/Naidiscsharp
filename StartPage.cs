using System;
using System.Collections.Generic;
using System.Text;

namespace Naidiscsharp
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Osa 1 - 5 ");
                Console.WriteLine("Vali meetod");
                Console.WriteLine("1 - Osa 1");
                Console.WriteLine("2 - Osa 2");
                Console.WriteLine("3 - Osa 3");
                Console.WriteLine("4 - Osa 4");
                Console.WriteLine("5 - Osa 5");
                Console.WriteLine("0 - Välju"); 

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        osa1.Osa1Main();
                        break;
                    case "2":
                        osa2startpage.Osa2Main();
                        break;
                    case "3":
                        osa3startpage.Osa3Main();
                        break;
                    case "4":
                        Osa4StartPAge.Osa4Main();
                        break;
                    case "5":
                        Osa5StartPage.Osa5Main();
                        break;
                    case "0":
                        return; 
                    default:
                        Console.WriteLine("Vale valik. Palun vali 1-5.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
    }
}