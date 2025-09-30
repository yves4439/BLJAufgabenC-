using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;

            Console.WriteLine("Bitte gib eine 2-stellige Ganzzahl ein.");
            int zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl > 99 || zahl < 10)
            {
                Console.WriteLine("Braschki gib eine zweistellige Zahl ein... (z.B. 67).");
                Environment.Exit(0);
            }

            Console.WriteLine("Bitte gib eine zweite 2-stellige Ganzzahl ein.");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            if (zahl2 > 99 || zahl2 < 10)
            {
                Console.WriteLine("Braschki gib eine zweistellige Zahl ein... (z.B. 67).");
                Environment.Exit(0);
            }

            Console.WriteLine("");
            Console.WriteLine("Zahl 1: " + zahl);
            Console.WriteLine("Zahl 2: " + zahl2);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"| {"Zahl",-7} | {"Quersumme",-11} | {"Zahl / Quersumme",-17}   |");
            Console.WriteLine("-----------------------------------------------");

            //**************************************************************************************************

            //int kopie = zahl;
            //int kopie2 = zahl2;

            //while (kopie != 0)
            //{
            //    sum += kopie % 10;
            //    kopie /= 10;
            //}

            //while (kopie2 != 0)
            //{
            //    sum2 += kopie2 % 10;
            //    kopie2 /= 10;
            //}

            //double division = (double)zahl / sum;
            //Console.WriteLine($"| {zahl,-7} | {sum,-11} | {division,-17:F0}   |");

            //double division2 = (double)zahl2 / sum2;
            //Console.WriteLine($"| {zahl2,-7} | {sum2,-11} | {division2,-17:F0}   |");

            //**************************************************************************************************

            int start = Math.Min(zahl, zahl2);
            int ende = Math.Max(zahl, zahl2);

            for (int wert = start; wert <= ende; wert++)
            {
                int quersumme = 0;
                int kopie = wert;
                while (kopie != 0)
                {
                    quersumme += kopie % 10;
                    kopie /= 10;
                }

                if (wert % quersumme == 0)
                {
                    double div = (double)wert / quersumme;
                    Console.WriteLine($"| {wert,-7} | {quersumme,-11} | {div,-17:F0}   |");
                }
            }

            Console.WriteLine("-----------------------------------------------");
        }
    }
}
