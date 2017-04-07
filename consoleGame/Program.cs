using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
