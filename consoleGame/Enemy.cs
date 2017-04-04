using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Enemy
    {
        private int locationX;
        private int locationY;
        private static bool flag = true;

        public Enemy()
        {
            Random r = new Random();
            locationX = r.Next(0,78);
            locationY = r.Next(0,25);
        }

        public void Movement()
        {
            if (locationX < 78 && flag)
                locationX++;
            else flag = false;
            if (locationX > 0 && !flag)
                locationX--;
            else flag = true;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("X");
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
