using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;


namespace Naidiscsharp.Itaaliatoit
{

    internal class ItaaliaFunktsioon
    {
        static string menuPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "menuu.txt");
        static List<Menu> menuuList = new List<Menu>();

        public static void LaeAndmedFailist()
        {
            Console.WriteLine("Laetakse andmeid failist...");
            if (File.Exists(menuPath))
            {
                string[] osad = File.ReadAllLines(menuPath);
                menuuList.Clear(); 
                foreach (string line in osad)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string nimetus = parts[0].Trim();
                        List<string> koostisosad = new List<string>(parts[1].Split(','));
                        double hind = double.Parse(parts[2].Trim(), CultureInfo.InvariantCulture);

                        Menu menuuItem = new Menu(nimetus, koostisosad, hind);
                        menuuList.Add(menuuItem);
                    }
                }
                Console.WriteLine($"Andmed on edukalt laaditud. Kokku on {menuuList.Count} toitu.");
            }
            else
            {
                Console.WriteLine("Andmefaili ei leitud. Palun veenduge, et 'menuu.txt' on olemas.");
            }
        }

        public static void ItaaliaRestoran()
        {
            Console.Clear();
            Console.WriteLine("Tere tulemast Itaalia restorani!");
            Console.WriteLine("=================================");
            Console.WriteLine("Menüü:");
            Console.WriteLine("=================================");
            if (menuuList.Count == 0)
            {
                Console.WriteLine("Menüü on tühi. Palun laadige andmed failist (Valik 1).");
            }
            else
            {
                foreach (Menu item in menuuList)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Nimetus: {item.Nimetus}");
                    Console.ResetColor();
                    Console.WriteLine($"Koostisosad: {string.Join(", ", item.Koostisosad)}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Hind: {item.Hind}€");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------------");
                }
            }
        }

        public static void LisaUusToit()
        {
            Console.WriteLine("Sisesta uue toidu info...");
            Console.Write("Nimetus: ");
            string nimetus = Console.ReadLine();

            List<string> koostisosad = new List<string>();
            while (true)
            {
                Console.Write("Koostisosa (või vajuta Enter, et lõpetada): ");
                string aine = Console.ReadLine();
                if (string.IsNullOrEmpty(aine))
                    break;
                koostisosad.Add(aine);
            }

            double hind;
            while (true)
            {
                Console.Write("Sisesta hind (nt 12.99): ");
                string sisend = Console.ReadLine();
                if (double.TryParse(sisend, NumberStyles.Any, CultureInfo.InvariantCulture, out hind))
                    break;
                Console.WriteLine("Viga: Palun sisesta korrektne arvuline hind.");
            }

            menuuList.Add(new Menu(nimetus, koostisosad, hind));
            Console.WriteLine($"Uus toit '{nimetus}' on menüüsse lisatud!");
        }

        public static void SalvestAndmedFaili()
        {
            Console.WriteLine("Salvestatakse andmed faili...");
            try
            {
                List<string> failiread = new List<string>();
                foreach (Menu item in menuuList)
                {
                    failiread.Add(item.VormidaFailijaokrea());
                }
                File.WriteAllLines(menuPath, failiread);
                Console.WriteLine("Andmed on edukalt salvestatud faili.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Andmete salvestamisel tekkis viga: {e.Message}");
            }
        }

        public static void KustutaToit()
        {
            Console.Write("Sisesta kustutava toidu nimetus: ");
            string nimetus = Console.ReadLine();
            Menu itemToRemove = menuuList.Find(item => item.Nimetus.Equals(nimetus, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                menuuList.Remove(itemToRemove);
                Console.WriteLine($"Toit '{nimetus}' on menüüst kustutatud.");
            }
            else
            {
                Console.WriteLine($"Toitu nimega '{nimetus}' ei leitud menüüst.");
            }
        }

        public static void ToiduInformatsioon()
        {
            Console.Write("Sisesta otsiva toidu nimetus: ");
            string nimetus = Console.ReadLine();
            Menu itemToShow = menuuList.Find(item => item.Nimetus.Equals(nimetus, StringComparison.OrdinalIgnoreCase));
            if (itemToShow != null)
            {
                Console.WriteLine($"Toit '{itemToShow.Nimetus}' sisaldab:");
                Console.WriteLine($"Koostisosad: {string.Join(", ", itemToShow.Koostisosad)}");
                Console.WriteLine($"Hind: {itemToShow.Hind}€");
            }
            else
            {
                Console.WriteLine($"Toitu nimega '{nimetus}' ei leitud menüüs.");
            }
        }
    }
}