using System;
using System.Collections.Generic;
using System.Text;

namespace Naidiscsharp
{
    internal class Inimene
    {
        internal class inimene
        {
            public string Nimi;
            public int Vanus;

            public inimene(string nimi, int vanus)
            {
                Nimi = nimi;
                Vanus = vanus;
            }
        }
    }
    public class inimene_osa5
    {

        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public int Aktiivsustase { get; set; }
        public inimene_osa5(string nimi, int vanus, string sugu, double pikkus, double kaal, int aktiivsustase)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsustase = aktiivsustase;
        }
    }
}
