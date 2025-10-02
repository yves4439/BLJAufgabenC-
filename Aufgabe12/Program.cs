using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("|              Zahlen aufsummieren                 |");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Gib die summierende Ganzzahlen mit Komma getrennt ein:");

            string eingabe = Console.ReadLine();
            string[] werte = eingabe.Split(',');

            int zahl1 = Convert.ToInt32(werte[0].Trim());
            int zahl2 = Convert.ToInt32(werte[1].Trim());
            int zahl3 = Convert.ToInt32(werte[2].Trim());
            int zahl4 = Convert.ToInt32(werte[3].Trim());

            int summe1 = zahl1;
            int summe2 = zahl1 + zahl2;
            int summe3 = zahl1 + zahl2 + zahl3;
            int summe4 = zahl1 + zahl2 + zahl3 + zahl4;


            Console.WriteLine("Resultat: ");
            Console.WriteLine("[0] -> " + summe1 + " [1] -> " + summe2 + " [2] -> " + summe3 + " [3] -> " + summe4);
        }

        static int[] SumUp(int[] arr)
        {
            int[] result = new int[arr.Length];
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                result[i] = sum;
            }

            return result;
        }
    }
}
