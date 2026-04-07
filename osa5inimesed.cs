using System;
using System.Collections.Generic;
using System.Text;

namespace Naidiscsharp
{
    internal class osa5inimesed
    {
        public class opilane
        {
            public string Nimi { get; set; }
            public List<int> Hinded { get; set; }

            public opilane(string nimi, List<int> hinded)
            {
                Nimi = nimi;
                Hinded = hinded ?? new List<int>();
            }

            public opilane()
            {
                Hinded = new List<int>();
            }
        }

        public class Lemmikloom
        {
            public string Nimi { get; set; }
            public string Liik { get; set; }
            public int Vanus { get; set; }
        }
    }
}