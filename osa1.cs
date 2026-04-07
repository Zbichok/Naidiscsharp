using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidiscsharp
{
    public class osa1
    {
        public static void Osa1Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            string tekst = "Tere tulemast C#-i maailma! ";
            Console.WriteLine($"oli loodud muutuja tekst, mis võrdun: {tekst}");
            Console.WriteLine("\"oli loodud muutuja tekst, mis võrdun: {0}", tekst);
            Console.Write("Mis on sinu nimi");
            string nimi = Console.ReadLine();

        }

    }
}
