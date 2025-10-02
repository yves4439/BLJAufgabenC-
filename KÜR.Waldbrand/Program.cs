using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜR.Waldbrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|             Waldbrand               |");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Breite des Waldes: ");
            int breite = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBHöhe des Waldes: ");
            int hoehe = int.Parse(Console.ReadLine());

            Console.Write("\nWahrscheinlichkeit z (Funkenentzündung in %): ");
            int z = int.Parse(Console.ReadLine());

            Console.Write("\nWahrscheinlichkeit w (Wachstum in %): ");
            int w = int.Parse(Console.ReadLine());

            Console.Clear();

            string Baum = "🌳";
            string Stein = "🪨";
            string Waldboden = "🟤";
            string Feuer = "🔥";
            string Glut = "🔴";

            string[,] raster = new string[hoehe, breite];
            Random rnd = new Random();

            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    int zufall = rnd.Next(100); 
                    if (zufall < 60)
                        raster[y, x] = Baum; 
                    else if (zufall < 80)
                        raster[y, x] = Stein; 
                    else
                        raster[y, x] = Waldboden; 
                }
            }

            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    Console.Write(raster[y, x]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
