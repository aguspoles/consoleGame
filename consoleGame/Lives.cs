using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Lives
    {
        private char life;
        private int nro;
        public Lives(char symbol , int cant)
        {
            life = symbol;
            nro = cant;
        }
        public  void Draw()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, 0);
            Console.Write("Lives : " + nro);
            for(int i = 0; i <nro; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 15, 0);
                Console.Write(life);

            }
        }
        public int getLives()
        {
            return nro;
        }
        public void setLive(int cant)
        {
            nro = cant;
        }
        public void LiveDown()
        {
            if (nro != 0){
                nro -= 1;
            }
           else
            {
                Game.gameLoop = false;
                
            }

        }
    }
}
