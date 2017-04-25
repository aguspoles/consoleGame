using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace consoleGame
{
    class Level
    {
        private int cuantEnemy = 30;
        private int cuantItem = 10;
        private Charecter player1;
        private Charecter player2;
        private Enemy[] enemys;
        private List<Item> items;
        private Checkpoint checkpoint;
        private int L;//para un jugador o dos jugadores

        private Lives life = new Lives('♥', 3);

        public ConsoleKeyInfo userKey;

        public Level(int l)
        {
            Score.score = 0;
            L = l;
            if (File.Exists("CharecterData.dat"))
            {
                Stream stream = File.Open("CharecterData.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                player1 = (Charecter)bf.Deserialize(stream);
                stream.Close();
            }
            else player1 = new Charecter(0, 0);

            if (L == 2)
                player2 = new Charecter(10, 0);

            enemys = new Enemy[cuantEnemy];
            items = new List<Item>();
            checkpoint = new Checkpoint();

            Random r = new Random();
            for (int i = 0; i < cuantEnemy; i++)
                enemys[i] = new Enemy(r.Next(0, Console.WindowWidth-2), r.Next(2, Console.WindowHeight-2));
           
            if (L == 1)
            {
                for (int i = 0; i < cuantItem; i++)
                    items.Add(new Item(r.Next(0, Console.WindowWidth - 2), r.Next(2, Console.WindowHeight - 2)));
            }
        }

        public void Run()
        {
            
            if (Console.KeyAvailable)
            {
                userKey = Console.ReadKey(true);
                if (userKey.Key == ConsoleKey.Escape)
                {
                    Stream stream = File.Open("CharecterData.dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, player1);
                    stream.Close();
                    return;
                }
                player1.Movement_1(userKey);
                if (L == 2)
                    player2.Movement_2(userKey);
            }

            for (int i = 0; i < enemys.Length; i++)
            {
                enemys[i].Movement();
                player1.EnemyCollision(enemys[i]);
                if (L == 2)
                    player2.EnemyCollision(enemys[i]);
            }

            if (L == 1)
            {
                player1.ItemCollision(items);
            }

            player1.CheckpointCollision(checkpoint);
            if (L == 2)
                player2.CheckpointCollision(checkpoint);

            Console.Clear();
            Draw();
        }

        public void Draw()
        {
            player1.Draw_1();
            if (L == 2)
                player2.Draw_2();
            checkpoint.Draw();
            for (int i = 0; i < enemys.Length; i++)
                enemys[i].Draw();
            if (L == 1)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    items[i].Draw();
                }
            }
            Score.Draw();
        }
    }
}
