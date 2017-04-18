using System;
using System.IO;

namespace consoleGame
{
    class Menu
    {
        private ConsoleKeyInfo userKey;

        public Menu()
        {
            string path = "C:/Users/rocio/Documents/Visual Studio 2015/Projects/consoleGame/juegoDeConsola/score.txt";
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("PRESS ENTER TO BEGIN WITH 1 PLAYER");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("PRESS SPACE TO BEGIN WITH 2 PLAYERS");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("PRESS ESCAPE TWICE TO EXIT");
            if(File.Exists(path))
            {
                FileStream fs = File.OpenRead(path);
                BinaryReader br = new BinaryReader(fs);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight/2);
                Console.Write(br.ReadString() + ": " + br.ReadInt32());
                br.Close();
                fs.Close();
            }
        }

        public ConsoleKeyInfo Run()
        {
            do 
            {
                userKey = Console.ReadKey();
            }while(userKey.Key != ConsoleKey.Enter && userKey.Key != ConsoleKey.Spacebar
                && userKey.Key != ConsoleKey.Escape);

            return userKey;
        }


    }
}
