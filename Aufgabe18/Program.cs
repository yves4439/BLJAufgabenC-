using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|            Vokalenzähler            |");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Deine Eingabe: ");
            string eingabe = Console.ReadLine();
            string vokale = "aeiouüöäAEIOUÜÄÖ";

            int a = 0, e = 0, i = 0, o = 0, u = 0, ä = 0, ö = 0, ü = 0;

            foreach (char c in eingabe)
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        a++;
                        break;
                    case 'e':
                    case 'E':
                        e++;
                        break;
                    case 'i':
                    case 'I':
                        i++;
                        break;
                    case 'o':
                    case 'O':
                        o++;
                        break;
                    case 'u':
                    case 'U':
                        u++;
                        break;
                    case 'ä':
                    case 'Ä':
                        ä++;
                        break;
                    case 'ö':
                    case 'Ö':
                        ö++;
                        break;
                    case 'ü':
                    case 'Ü':
                        ü++;
                        break;
                }
            }

            int gesamt = a + e + i + o + u + ä + ö + ü;

            Console.WriteLine("\n\nDeine Eingabe entählt insgesamt  " + gesamt + " Vokale.");
            Console.WriteLine("\nEinzelne Vokale:");
            Console.WriteLine("Vokal A/a kommt " + a + " mal vor.");
            Console.WriteLine("Vokal E/e kommt " + e + " mal vor.");
            Console.WriteLine("Vokal I/i kommt " + i + " mal vor.");
            Console.WriteLine("Vokal O/o kommt " + o + " mal vor.");
            Console.WriteLine("Vokal U/u kommt " + u + " mal vor.");
            Console.WriteLine("Vokal Ä/ä kommt " + ä + " mal vor.");
            Console.WriteLine("Vokal Ö/ö kommt " + ö + " mal vor.");
            Console.WriteLine("Vokal Ü/ü kommt " + ü + " mal vor.");
        }
    }
}
