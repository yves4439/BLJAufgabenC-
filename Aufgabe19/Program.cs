using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|           Taschenrechner            |");
            Console.WriteLine("---------------------------------------");

            while (true)
            {
                Console.WriteLine("\nGib 2 Zahlen mit einem Opperator dazwischen ein (q zum beenden):");
                Console.WriteLine("");

                string eingabe = Console.ReadLine();
                int ersteZahl = 0, zweiteZahl = 0;
                char opperator = ' ';

                if (eingabe.ToLower() == "q")
                {
                    Environment.Exit(0);
                }

                else
                {
                    foreach (char c in eingabe)
                    {
                        if (c == '+' || c == '-' || c == '*' || c == '/')
                        {
                            opperator = c;
                            string[] zahlen = eingabe.Split(c);
                            ersteZahl = Convert.ToInt32(zahlen[0]);
                            zweiteZahl = Convert.ToInt32(zahlen[1]);
                            break;
                        }
                    }

                    switch (opperator)
                    {
                        case '+':
                            Console.WriteLine("=" + ersteZahl + zweiteZahl);
                            break;

                        case '-':
                            Console.WriteLine("=" + (ersteZahl - zweiteZahl)); 
                            break;

                        case '*':
                            Console.WriteLine("=" + ersteZahl * zweiteZahl);
                            break;

                        case '/':
                            if (ersteZahl == 0)
                            {
                                Console.WriteLine("ERROR");
                            }
                            else
                            {
                                Console.WriteLine("=" + ersteZahl / zweiteZahl);
                            }
                            break;

                        default:
                            Console.WriteLine("Ungültiger Opperator");
                            break;
                    }
                }
            }
        }
    }
}
