using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Level
    {
        public static int cuantEnemy = 10;
        private Charecter c;
        private Enemy[] es;

        public Level()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            c = new Charecter();
            es = new Enemy[cuantEnemy];
            for (int i = 0; i < cuantEnemy; i++)
                es[i] = new Enemy();
            Draw();//para q dibuje cuando arranque
        }

        public void Run()
        {
            if (Console.KeyAvailable)
            {
                c.Movement();
            }
            for (int i = 0; i < cuantEnemy; i++)
            {
                es[i].Movement();
                c.EnemyCollision(es[i]);
            }
            Console.Clear();
            Draw();
        }

        public void Draw()
        {
            c.Draw();
            for(int i = 0; i < cuantEnemy; i++)
                es[i].Draw();
        }
    }
}
