using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monatsname Ausgabe");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Zahl eingeben: ");
            int monat;
            string Eingabe = Console.ReadLine();

            if (int.TryParse(Eingabe, out monat) && monat >= 1 && monat <= 12)
            {
                string[] monate =
                    { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"};

                Console.WriteLine($"Monat: {monate[monat - 1]}");
            }

            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }
        }
    }
}
