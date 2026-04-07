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
            ItaaliaFunktsioon.LaeAndmedFailist();
            while (true)
                Console.WriteLine("Tere tulemast Itaalia restorani");
            Console.WriteLine("1. Laemine anmeid failist ");
            Console.WriteLine("2. Menüü vaatmine ");
            Console.WriteLine("3. Uue toidu lisamine");
            Console.WriteLine("4. Amdmete salvestamine");
            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    ItaaliaFunktsioon.LaeAndmedFailist();
                    break;
                case 2:
                    ItaaliaFunktsioon.ItaaliaRestoran();
                    break;
                case 3:
                    ItaaliaFunktsioon.LisaUusToit();
                    break;
                case 4:
                    ItaaliaFunktsioon.SalvestAndmedFaili();
                    break;
                case 5:
                    ItaaliaFunktsioon.KustutaToit();
                case 6:
                    ItaaliaFunktsioon.ToiduInformatsioon();
                    break;

            }
        }
    }
}
