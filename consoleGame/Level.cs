using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Level
    {
        private int cuantEnemy = 30;
        private Charecter c;
		private Charecter d;
        private Enemy[] es;
        private Checkpoint cp;
        private int L;

		public Level(int l)
        {
            L = l;
            c = new Charecter(0,0);
			if(L == 2)
				d = new Charecter(10,0);
			
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
                c.Movement_1();
                if (L == 2)
                    d.Movement_2();
            }

                for (int i = 0; i < cuantEnemy; i++)
                {
                    es[i].Movement();
                    c.EnemyCollision(es[i]);
                    if (L == 2)
                        d.EnemyCollision(es[i]);
                }
                c.CheckpointCollision(cp);
                if (L == 2)
                    d.CheckpointCollision(cp);
                Console.Clear();
                Draw();
        }

        public void Draw()
        {
            c.Draw_1();
			if (L == 2)
				d.Draw_2();
            cp.Draw();
            for (int i = 0; i < cuantEnemy; i++)
                es[i].Draw();
        }
    }
}
