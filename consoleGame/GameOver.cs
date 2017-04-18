using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class GameOver
    {
        public GameOver()
        {
            Score.Draw();
        }


        public void Win()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("YOU WIN!");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("PRESS ESCAPE TO QUIT");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("PRESS ENTER TO RESTART");
        }

        public void Loss()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("END OF GAME");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("PRESS ESCAPE TO QUIT");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("PRESS ENTER TO RESTART");
        }
    }
}
