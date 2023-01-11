using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        //fields
       public int x;
       public int y;
       public int health;
       public int shield;
       public int lives;

        //methods
        public Player()// constructor
        {
            health = 100;
            shield = 100;
            lives = 3;
            Console.WriteLine("Player class constructed...");
        }
        public void TakeDamage(int hp)
        {
            health -= hp;
        }
    }
}
