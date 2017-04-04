using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Game
    {
        public static bool gameLoop;
        private Level actual;

        public Game()
        {
            gameLoop = true;
            actual = new Level();
        }

        public void Run()
        {
            Console.SetCursorPosition(35, 15);
            Console.WriteLine("MENU");
            while (gameLoop)
            {
                actual.Run();
                System.Threading.Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(35, 15);
            Console.WriteLine("FIN DEL JUEGO");
        }
    }
}
