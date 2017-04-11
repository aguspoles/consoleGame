using System;
using System.IO;

namespace consoleGame
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo userKey;
            Console.Title = "CONSOLE GAME";
            do
            {
                Game g = new Game();
                g.Run();
                do
                {
                    userKey = Console.ReadKey();
                    if (userKey.Key == ConsoleKey.Escape)
                        break;
				} while (userKey.Key != ConsoleKey.Enter && userKey.Key != ConsoleKey.Spacebar);
                Console.Clear();
            }
            while (userKey.Key == ConsoleKey.Enter);

           /* FileStream fs = File.Create("datosJuego.txt");
            StreamWriter sw = new StreamWriter("datosJuegos.txt");
            sw.WriteLine("Hola mundo");
            sw.Close();
            fs.Close();

            FileStream xs = File.OpenRead("datosJuego.txt");
            StreamReader sr = new StreamReader(fs);
            sr.Close();
            xs.Close();*/
        }


    }
}
