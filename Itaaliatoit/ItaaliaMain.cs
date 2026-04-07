using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp.Itaaliatoit
{
    internal class ItaaliaMain
    {
        public static void MainItalia(string[] args)
        {
            bool tootab = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tere tulemast Itaalia restorani");
                Console.WriteLine("1. Laemine andmeid failist ");
                Console.WriteLine("2. Menüü vaatmine ");
                Console.WriteLine("3. Uue toidu lisamine");
                Console.WriteLine("4. Andmete salvestamine");
                Console.WriteLine("5. Toidu kustutamine");
                Console.WriteLine("6. Toidu info");
                Console.Write("Vali tegevus: ");

                int valik = int.Parse(Console.ReadLine());
                switch (valik)
                {
                    case 1: ItaaliaFunktsioon.LaeAndmedFailist(); break;
                    case 2: ItaaliaFunktsioon.ItaaliaRestoran(); break;
                    case 3: ItaaliaFunktsioon.LisaUusToit(); break;
                    case 4: ItaaliaFunktsioon.SalvestAndmedFaili(); break;
                    case 5: ItaaliaFunktsioon.KustutaToit(); break;
                    case 6: ItaaliaFunktsioon.ToiduInformatsioon(); break;
                    default: Console.WriteLine("Valik puudub, proovi uuesti."); break;
                }

                Console.WriteLine("Vajuta Enter, et jätkata...");
                Console.ReadLine();
            }
        }
    }
}
