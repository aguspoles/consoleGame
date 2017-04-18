using System;
using System.IO;

namespace consoleGame
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo userKey;
            Console.CursorVisible = false;
            Console.Title = "CONSOLE GAME";

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

                if (userKey.Key == ConsoleKey.Escape) break;
             }


        }

        //disparo cool
        /*      if (teclaUsada.Key == ConsoleKey.Spacebar)
                {
                    for (int i = GetLocationX(); i < Console.WindowWidth-1; i++)
                    {
                        Console.SetCursorPosition(i, GetLocationY());
                        Console.Write("*");
                    }
                }*/


    }
}
