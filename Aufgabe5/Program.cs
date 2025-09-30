using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rundenberechner");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int howMuchKm = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int n = (howMuchKm * 1000 / 400);

            if (howMuchKm <= 42)
            {
                Console.WriteLine("\nDas sind " + (n) + " Runden. Bereit für den Lauf?");
                Console.WriteLine("Bereit? (0 für ja oder 1 für nein)");
                int ready = Convert.ToInt32(Console.ReadLine());

                if (ready == 0)
                {

                    while (i <= n)
                    {
                        Console.WriteLine("\nDu läufst gerade Runde: " + i);
                        i++;

                    }

                    Console.WriteLine("\nDu hast es geschafft!");


                }

                else if (ready == 1)
                {
                    Console.WriteLine("\nDu Lutscher!");
                }

            }

            else
            {
                Console.WriteLine("\n\nDas schaffst du nicht!");
            }

        }
    }
}
