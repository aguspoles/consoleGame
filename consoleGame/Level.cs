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
		public bool jug2;
        private Charecter c;
		private Charecter d;
        private Enemy[] es;
        private Checkpoint cp;

		public Level(bool cant)
        {
			jug2 = cant;
            c = new Charecter(true);
			if(jug2)
				d = new Charecter (false);
			
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
				if(jug2)
					d.Movement();
            }
            for (int i = 0; i < cuantEnemy; i++)
            {
                es[i].Movement();
                c.EnemyCollision(es[i]);
				if (jug2)
					d.EnemyCollision (es [i]);
            }
            c.CheckpointCollision(cp);
			if (jug2)
				d.CheckpointCollision (cp);
            Console.Clear();
            Draw();
        }

        public void Draw()
        {
            c.Draw();
			if (jug2)
				d.Draw ();
            cp.Draw();
            for (int i = 0; i < cuantEnemy; i++)
                es[i].Draw();
        }
    }
}
