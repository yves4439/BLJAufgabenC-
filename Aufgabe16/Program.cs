using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|               Zahlratespiel               |");
            Console.WriteLine("---------------------------------------------");

            Random nummer = new Random();

            int geheim = nummer.Next(0, 101);

            Console.WriteLine("Rate eine Zahl von 1 bis 100:");

            while (true)
            {
                string input = Console.ReadLine();
            
                if (int.TryParse(input, out int hinweis))
                {
                    if (hinweis < 1 || hinweis > 100)
                    {
                        Console.WriteLine("Ungültige Eingabe. (Zahl 1 -100)");
                        continue;
                    }

                    if (hinweis == geheim)
                    {
                        Console.WriteLine("Die Zahl stimmt! Möchtest du noch einmal spielen? (Ja/Nein)");
                        while (true)
                        {
                            string Antwort = Convert.ToString(Console.ReadLine());
                            if (Antwort == "Ja")
                            {
                                Console.Clear();
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine("|               Zahlratespiel               |");
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine("Rate eine Zahl von 1 bis 100:");
                                break;
                            }
                            else if (Antwort == "Nein")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Gib Ja oder Nein ein!");
                            }
                        }
                    }
                    else if (hinweis < geheim)
                    {
                        Console.WriteLine("Zahl ist zu klein, versuche es nochmal!");
                    }
                    else
                    {
                        Console.WriteLine("Zahl ist zu hoch, versuche es nochmal!");
                    }
                }
                else 
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }
        }
    }
}
