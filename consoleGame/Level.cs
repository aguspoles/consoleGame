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
        private Enemy[] es = new Enemy[cuantEnemy];

        public Level()
        {
            c = new Charecter();
            for (int i = 0; i < cuantEnemy; i++)
                es[i] = new Enemy();
            Draw();
        }

        public void Run()
        {
            if (Console.KeyAvailable)
            {
                c.Movement();
                for (int i = 0; i < cuantEnemy; i++)
                    es[i].Movement();
            }
        }

        public void Draw()
        {
            c.Draw();
            for(int i = 0; i < cuantEnemy; i++)
                es[i].Draw();
        }
    }
}
