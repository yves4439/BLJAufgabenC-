using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Diese Aufgabe addiert zwei Zahlen.");

            Console.WriteLine("Gib die erste Zahl ein.");
            int ersteZahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Gib die zweite Zahl ein.");
            int zweiteZahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");


            Console.WriteLine("Zahl 1: " + ersteZahl);
            Console.WriteLine("Zahl 2: " + zweiteZahl);

            Console.WriteLine("");

            Console.WriteLine("Ergebnis: " + (ersteZahl + zweiteZahl));
        }
    }
}
