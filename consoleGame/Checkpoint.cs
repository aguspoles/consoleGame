using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Checkpoint
    {
        private int locationX;
        private int locationY;

        public Checkpoint()
        {
            locationX = 77;
            locationY = 23;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("**");
            Console.SetCursorPosition(locationX, locationY+1);
            Console.Write("**");
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
