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
        private bool UP, DOWN, LEFT, RIGHT;
       
        

        public Charecter(int x, int y)
        {
            locationX = x;
            locationY = y;
            UP = DOWN = LEFT = RIGHT = true;
        }

        public void Movement_1(ConsoleKeyInfo userKey)
        {
            switch (userKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (locationX >= 1 && LEFT)
                    {
                        locationX -= 1;
                        LEFT = false;
                        RIGHT = DOWN = UP = true;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (locationX < Console.WindowWidth-1 && RIGHT)
                    {
                        locationX += 1;
                        RIGHT = false;
                        LEFT = UP = DOWN = true;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (locationY >= 1 && UP)
                    {
                        locationY -= 1;
                        UP = false;
                        DOWN = LEFT = RIGHT = true;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (locationY < Console.WindowHeight - 1 && DOWN)
                    {
                        locationY += 1;
                        DOWN = false;
                        UP = RIGHT = LEFT = true;
                    }
                    break;

                case ConsoleKey.Escape:
                    Game.gameLoop = false;
                    break;
            }

        }

        public void Movement_2(ConsoleKeyInfo userKey)
        {
            switch (userKey.Key)
            {
                case ConsoleKey.A:
                    if (locationX >= 1 && LEFT)
                    {
                        locationX -= 1;
                        LEFT = false;
                        RIGHT = DOWN = UP = true;
                    }
                    break;

                case ConsoleKey.D:
                    if (locationX < Console.WindowWidth - 1 && RIGHT)
                    {
                        locationX += 1;
                        RIGHT = false;
                        LEFT = UP = DOWN = true;
                    }
                    break;

                case ConsoleKey.W:
                    if (locationY >= 1 && UP)
                    {
                        locationY -= 1;
                        UP = false;
                        DOWN = LEFT = RIGHT = true;
                    }
                    break;

                case ConsoleKey.S:
                    if (locationY < Console.WindowHeight-1 && DOWN)
                    {
                        locationY += 1;
                        DOWN = false;
                        UP = RIGHT = LEFT = true;
                    }
                    break;
                case ConsoleKey.Spacebar:


                case ConsoleKey.Escape:
                    Game.gameLoop = false;
                    break;
            }

        }


        public void Draw_1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("%");
        }

        public void Draw_2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("@");
        }
        //No pude hacer que me funcionara el life down , asi q intente cambiandolo a un bool ;
        public bool EnemyCollision(Enemy e)
        {
            if (locationX == e.GetLocationX()
                && locationY == e.GetLocationY())
            {
                return true;
            }
            else
                return false;
        }
       /* public bool EnemyCollision(Enemy e)
        {
            if (locationX == e.GetLocationX()
                && locationY == e.GetLocationY())
            {
                Game.gameLoop = false;
            }
            */
        public void ItemCollision(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (locationX == items[i].GetLocationX()
                    && locationY == items[i].GetLocationY())
                {
                    items.Remove(items[i]);
                    Score.score++;
                }
            }
        }

        public void CheckpointCollision(Checkpoint cp)
        {
            if ((locationX == cp.GetLocationX()
                && locationY == cp.GetLocationY())
                || (locationX == cp.GetLocationX() + 1
                && locationY == cp.GetLocationY() + 1))
            {
                Game.gameLoop = false;
                Game.win = true;
            }
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



    }
}
