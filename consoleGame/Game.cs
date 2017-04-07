﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Game
    {
        public static bool gameLoop;
        public static bool win;
        private Level actual;
        private ConsoleKeyInfo userKey;

        public Game()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            gameLoop = true;
            win = false;

        }

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Console.WindowWidth/2 - 4,Console.WindowHeight/2 - 2);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(Console.WindowWidth / 2 -11, Console.WindowHeight / 2 + 1);
            Console.WriteLine("PRESS ENTER TO BEGIN WITH 1 PLAYER");
			Console.SetCursorPosition(Console.WindowWidth / 2 -13, Console.WindowHeight / 2 + 3);
			Console.WriteLine("PRESS SPACE TO BEGIN WITH 2 PLAYERS");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 + 5);
            Console.WriteLine("PRESS ESCAPE TWICE TO EXIT");

                userKey = Console.ReadKey();
                if (userKey.Key == ConsoleKey.Escape)
                    return;

			while (userKey.Key != ConsoleKey.Enter && userKey.Key != ConsoleKey.Spacebar)
            {
                userKey = Console.ReadKey();
            } 

			if (userKey.Key == ConsoleKey.Enter) {
				actual = new Level(false);
			} else if (userKey.Key == ConsoleKey.Spacebar) {
				actual = new Level (true);
			}

            while (gameLoop)
            {
                actual.Run();
                System.Threading.Thread.Sleep(50);
            }

            Console.Clear();
            if (win)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
                Console.WriteLine("YOU WIN!");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 12, Console.WindowHeight / 2 + 1);
                Console.WriteLine("PRESS ESCAPE TO QUIT");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 2);
                Console.WriteLine("PRESS ENTER TO RESTART");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2);
                Console.WriteLine("END OF GAME");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 12, Console.WindowHeight / 2 + 1);
                Console.WriteLine("PRESS ESCAPE TO QUIT");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 2);
                Console.WriteLine("PRESS ENTER TO RESTART");
            }

      
        }
    }
}
