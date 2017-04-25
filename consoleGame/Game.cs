using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace consoleGame
{
    class Game
    {
        public static bool gameLoop;
        public static bool win;
        private Level actual;
        private ConsoleKeyInfo userKey;
        private Menu menu;
        private GameOver gameOver;

       private Lives life = new Lives('♥', 3);

        public Game()
        {
            gameLoop = true;
            win = false;
            Score.score = 0;
        }

        public void Run()
        {
            //Mensaje
            string path = "mensaje.txt";
            Message(path);

            //Menu
            MenuState();
            if (userKey.Key == ConsoleKey.Enter)
            {
                actual = new Level(1);
            }
            else if (userKey.Key == ConsoleKey.Spacebar)
            {
                actual = new Level(2);
            }
            else if(userKey.Key == ConsoleKey.Escape) return;//termino el juego


            //Game Loop
            while (gameLoop)
            {
                actual.Run();
                life.Draw();
                if(actual.userKey.Key == ConsoleKey.Escape)
                {
                    //back to menu
                    Console.Clear();
                    Message(path);
                    MenuState();
                    if (userKey.Key == ConsoleKey.Enter)
                    {
                        actual = new Level(1);
                    }
                    else if (userKey.Key == ConsoleKey.Spacebar)
                    {
                        actual = new Level(2);
                    }
                    else if(userKey.Key == ConsoleKey.Escape) return;//termino el juego
                }
                System.Threading.Thread.Sleep(50);
            }

            Console.Clear();

            //Game Over
            gameOver = new GameOver();
            if (win)
            {
                gameOver.Win();
            }
            else
            {
                gameOver.Loss();
            }

            string path1 = "score.txt";
            SaveHighScore(path1);
        }


        public void MenuState()
        {
            menu = new Menu();
            userKey = menu.Run();
        }

        public void Message(string path)
        {
            Console.ForegroundColor = ConsoleColor.White;
            FileStream fs;
            if (!File.Exists(path))
            {
                fs = File.Create(path);
                StreamWriter sw = new StreamWriter(fs);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight/2);
                Console.WriteLine("Ingrese mensaje de bienvenida: ");
                string datos = Console.ReadLine();
                sw.WriteLine(datos);
                sw.Close();
                Console.Clear();
            }
            fs = File.OpenRead(path);
            StreamReader sr = new StreamReader(fs);
            Console.SetCursorPosition(0, Console.WindowHeight/2);
            Console.Write("Mensaje: " + sr.ReadLine());
            sr.Close();
            fs.Close();
        }

        public void SaveHighScore(string path)
        {
            if (File.Exists(path))
            {
                FileStream fs1 = File.OpenRead(path);
                BinaryReader br = new BinaryReader(fs1);
                br.ReadString();
                int highScore = br.ReadInt32();
                br.Close();
                if (highScore < Score.score)
                {
                    WriteScore(path);
                }
                fs1.Close();
            }
            else WriteScore(path);
        }

        public void WriteScore(string path)
        {
            FileStream fs = File.OpenWrite(path);
            BinaryWriter bw = new BinaryWriter(fs);
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            bw.Write(nombre);
            bw.Write(Score.score);
            bw.Close();
            fs.Close();
        }

        public void ReadScore(string path)
        {
            FileStream fs = File.OpenRead(path);
            BinaryReader br = new BinaryReader(fs);
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2-5);
            Console.Write(br.ReadString() + ": " + br.ReadInt32());
            br.Close();
            fs.Close();
        }
        
    }
}
