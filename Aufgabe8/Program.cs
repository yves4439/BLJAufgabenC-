using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frobiddenwords = { "Fotze", "Batsard", "Hure", "Schlampe", "Hurensohn", "Wichser",
                "Scheisse", "Penis", "Schwanz", "Muschi", "Kar", "Dildo", "Satknis Nahui", "Du te dracu",
                "Arschloch", "Arsch", "Sex", "fick", "Ayri", "Bitch", "Porno", "Fick", "Nuttensohn", "Fuck",
                "fuck" , "fotze", "batsard", "hure", "schlampe", "hurensohn", "wichser","scheisse",
                "penis", "schwanz", "muschi", "kar", "dildo", "satknis nahui", "du te dracu",
                "arschloch", "arsch", "Sex", "fick", "ayri", "bitch", "porno", "fick", "nuttensohn"};

            Console.WriteLine("Bitte gib einen Kommentar deiner Wahl ein.:");
            string kommentar = Console.ReadLine();
            bool verboten = false;


            for (int i = 0; i < frobiddenwords.Length; i++)
            {
                if (kommentar.Contains(frobiddenwords[i]))
                {
                    verboten = true;
                    break;
                }
            }

            if (verboten)
            {
                Console.WriteLine("Dein Kommentar enthält verbotene Wörter. Twin ist nicht locked in!!");
            }
            else
            {
                Console.WriteLine("Danke für deinen Kommentar Brashki! Tuff FR Twin ist locked in!");
            }
        }
    }
}
