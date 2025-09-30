using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binäre Darstellung von ganzen Zahlen");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bitte gib eine ganze Zahl ein:\n");

            int zahl = Convert.ToInt32(Console.ReadLine());
            string binär = Convert.ToString(zahl, 2);
            Console.WriteLine("");
            Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + binär);
        }
    }
}
