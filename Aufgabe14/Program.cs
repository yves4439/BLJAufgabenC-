using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("       Schaltjahre");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Prüfen ob es sich bei einer Jahreszahl deiner Wahl um ein Schaltjahr handelt oder nicht");

            while (true)
            {
                Console.WriteLine("\nEingabe Jahr (q to quit)");

                string eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "q")
                {
                    Environment.Exit(0);
                }

                int Jahr = Convert.ToInt32(eingabe);

                if (Jahr % 4 == 0)
                {
                    Console.WriteLine("Das angegebene Jahr ist ein Schaltjahr.");
                }

                else
                {
                    Console.WriteLine("Das angegebene Jahr ist KEIN Schaltjahr!");
                }
            }
        }
    }
}
