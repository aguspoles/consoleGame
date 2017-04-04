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

        public Enemy()
        {
            Random r = new Random();
            locationX = r.Next(0,78);
            locationY = r.Next(0,25);
        }

        public void Movement()
        {
            Draw();
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Random r = new Random();
            locationX = r.Next(0, 78);
            locationY = r.Next(0, 25);
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("X");
        }
    }
}
