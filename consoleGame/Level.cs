using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Level
    {
        private  int cuantEnemy = 30;
        private Charecter c;
        private Enemy[] es;
        private Checkpoint cp;

        public Level()
        {
            c = new Charecter();
            es = new Enemy[cuantEnemy];
            cp = new Checkpoint();

            Random r = new Random();
            for (int i = 0; i < cuantEnemy; i++)
                es[i] = new Enemy(r.Next(0,78),r.Next(2,24));
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
            c.CheckpointCollision(cp);
            Console.Clear();
            Draw();
        }

        public void Draw()
        {
            c.Draw();
            cp.Draw();
            for (int i = 0; i < cuantEnemy; i++)
                es[i].Draw();
        }
    }
}
