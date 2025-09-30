using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|              Alters Berechnung                  |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bitte gib dein Geburtsdatum ein (DD.MM.JJJJ):");

            string input = Console.ReadLine();
            while(true)
            {
                if (DateTime.TryParse(input, out DateTime geburtsdatum))
                {
                    DateTime heute = DateTime.Today;

                    int jahre = heute.Year - geburtsdatum.Year;
                    int monate = heute.Month - geburtsdatum.Month;
                    int tage = heute.Day - geburtsdatum.Day;

                    Console.WriteLine("\n\nAlter in Jahren: " + jahre);
                    Console.WriteLine("Alter in Monaten: " + (jahre * 12 + monate));
                    Console.WriteLine("Alter in Tagen: " + (jahre * 365 + tage));

                    Console.WriteLine("\n\nMöchtest du ein anderes Geburtsdatum eingeben? (Ja/Nein)");
                    string antwort = Console.ReadLine();

                    if (antwort == "Ja") 
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("|              Alters Berechnung                  |");
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Bitte gib dein Geburtsdatum ein (DD.MM.JJJJ):");
                        input = Console.ReadLine();
                    }
                    else if(antwort == "Nein")
                    {
                        Environment.Exit(0)
;                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("\n\nUngültige Eingabe.");
                    continue;
                }

            }
        }
    }
}
