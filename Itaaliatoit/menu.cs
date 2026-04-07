using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp.Itaaliatoit
{
    internal class Menu
    {
        public string Nimetus { get; set; }
        public List<string> Koostisosad { get; set; }
        public double Hind { get; set; }
        public Menu(string nimetus, List<string> koostisosad, double hind)
        {
            Nimetus = nimetus;
            Koostisosad = koostisosad;
            Hind = hind;
        }
        public string VormidaFailijaokrea()
        {
            string ained = string.Join(",", Koostisosad);
            return $"{Nimetus}; {ained}; {Hind}";
        }
    }
}