using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("            Diagonale Linie erstellen");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Bitte gib die gewünschte Länge der Diagonalen an:");

            int länge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("Darstellung:");

            for (int zeile = 0; zeile < länge; zeile++)
            {
                for (int spalte = 0; spalte < länge; spalte++)
                {
                    if (spalte == zeile)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
