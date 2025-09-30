using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein.");
            int i = Convert.ToInt32(Console.ReadLine());



            if (i > 10)
            {
                Console.WriteLine("ENDE");
            }
            else
            {
                while (i <= 10)
                {
                    Console.WriteLine(i++);
                }

                Console.WriteLine("ENDE");
            }
        }
    }
}
