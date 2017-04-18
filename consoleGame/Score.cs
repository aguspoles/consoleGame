using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Score
    {
        public static int score = 0;

        public static void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4, 0);
            Console.Write("SCORE:" + score);
        }
    }
}
