using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Charecter
    {
        private int locationX = 0;
        private int locationY = 0;
        private ConsoleKeyInfo userKey;

        public void Movement()
        {
            if (Console.KeyAvailable)
            {
                userKey = Console.ReadKey(true); 

                switch (userKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (locationX > 0)
                        {
                            locationX -= 1;
                            Draw();
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (locationX < 78)
                        {
                            locationX += 1;
                            Draw();
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (locationY > 0)
                        {
                            locationY -= 1;
                            Draw();
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (locationY < 24)
                        {
                            locationY += 1;
                            Draw();
                        }
                        break;

                    case ConsoleKey.Enter:
                        Game.gameLoop = false;
                        break;
                }
            
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("@");
        }
    }
}
