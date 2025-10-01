using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breite des Stammes: ");
            int stammbreite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Höhe des Stammes: ");
            int stammhöhe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Höhe der Krone: ");
            int kronenhöhe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            ZeichneKrone(kronenhöhe);
            ZeichneStamm(stammbreite, stammhöhe, kronenhöhe);
        }

        static void ZeichneKrone(int höhe)
        {
            for (int i = 1; i <= höhe; i++)
            {
                for (int j = 0; j < höhe - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void ZeichneStamm(int breite, int hoehe, int kronenhöhe)
        {
            int abstand = kronenhöhe - breite / 2 - 1;

            for (int i = 0; i < hoehe; i++)
            {
                for (int j = 0; j < abstand; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < breite; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

