using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|            Witze erzählen           |");
            Console.WriteLine("---------------------------------------");

            while (true)
            {
                Console.Write("\nWillst du einen Witz hören? - ");
                string antwort = Console.ReadLine();

                if (antwort == "ja" || antwort == "Ja")
                {
                    WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                    WebResponse response = request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    string jsonData = new StreamReader(responseStream).ReadToEnd();
                    JArray array = JArray.Parse(jsonData);

                    string joke = array[0]["text"].ToString();
                    Console.WriteLine("\n" + joke);
                }
                else if (antwort == "nein" || antwort == "Nein")
                {
                    Console.WriteLine("\nOkey, bis zum nächsten mal!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nUngültige Eingabe. Schreibe Ja/Nein.");
                }

            }
        }
    }
}
