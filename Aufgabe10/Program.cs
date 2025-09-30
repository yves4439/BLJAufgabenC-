using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quersumme \n---------------------------------------");
            Console.WriteLine("Bitte gib eine beliebige Zahl ein:");
            Console.WriteLine("");

            int zahl = int.Parse(Console.ReadLine());
            int sum = 0;

            while (zahl != 0)
            {
                sum += zahl % 10;
                zahl /= 10;
            }

            Console.WriteLine("");
            Console.WriteLine("Die Quersumme ist " + sum + ".");
        }
    }
}
