using System;
using System.IO;
using System.Net;

using Newtonsoft.Json.Linq;

namespace consoleGame
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo userKey;
            Console.CursorVisible = false;
            Console.Title = "CONSOLE GAME";
            try
            {
                WebRequest req = WebRequest.Create("https://query.yahooapis.com/v1/public/yql?q=select%20item.condition.text%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22buenoa%20aires%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
                WebResponse respuesta = req.GetResponse();
                Stream stream = respuesta.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                JObject data = JObject.Parse(sr.ReadToEnd());
                string clima = data["query"]["results"]["channel"]["item"]["condition"]["text"].ToString();
                if (clima == "Cloudy")
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                else if (clima == "Sunny")
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                else Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            catch { }

            while (true)
             {
                Console.Clear();
                Game g = new Game();
                g.Run();
                do
                {
                    userKey = Console.ReadKey();
                } while (userKey.Key != ConsoleKey.Enter &&
                userKey.Key != ConsoleKey.Escape);

                if (userKey.Key == ConsoleKey.Escape)
                {
                    break;
                }
             }

            if(File.Exists("CharecterData.dat"))
                File.Delete("CharecterData.dat");


        }



    }
}
