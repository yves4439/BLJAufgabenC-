using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30 die durch 5 und/oder 3 ohne Rest teilbar sind:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("");

            bool Ja = true;

            for (int Zahl = 1; Zahl <= 30; Zahl++)
            {
                if (Zahl % 3 == 0 || Zahl % 5 == 0)
                {
                    if (!Ja)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(Zahl);
                    Ja = false;
                }
            }

            Console.WriteLine("");
        }
    }
}
