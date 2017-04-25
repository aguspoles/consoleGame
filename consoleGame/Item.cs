using System;

namespace consoleGame
{
    class Item
    {
        private int locationX;
        private int locationY;

        public Item(int x, int y)
        {
            locationX = x;
            locationY = y;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(locationX, locationY);
            Console.Write("<>");
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
