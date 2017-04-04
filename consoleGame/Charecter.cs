using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Charecter
    {
        private int locationX;
        private int locationY;
        private ConsoleKeyInfo userKey;

        public Charecter()
        {
            locationX = 5;
            locationY = 5;
        }

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
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (locationX < 78)
                        {
                            locationX += 1;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (locationY > 0)
                        {
                            locationY -= 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (locationY < 24)
                        {
                            locationY += 1;
                        }
                        break;

                    case ConsoleKey.Enter:
                        Game.gameLoop = false;
                        break;
                }

                Draw();    
            }
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("@");
        }

        public int GetLocationX()
        {
            return locationX;
        }

        public int GetLocationY()
        {
            return locationY;
        }

        public void SetLocationX(int x)
        {
            locationX = x;
        }

        public void SetLocationY(int y)
        {
            locationY = y;
        }

        public void EnemyCollision(Enemy e)
        {
            if (locationX == e.GetLocationX()
                && locationY == e.GetLocationY())
            { 
                Game.gameLoop = false;
            }
        }

 
    }
}
