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
            while (gameLoop)
            {
                actual.Run();
            }
        }
    }
}
