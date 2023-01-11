using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        struct Vector2
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Classes");
            Console.WriteLine();

            Vector2 position;
            position.x = 10;
            position.y = 10;
                

            Player player = new Player();
           
            Console.WriteLine("Health: " + player.health);
            Console.WriteLine("Shield: " + player.shield);
            Console.WriteLine("Lives: " + player.lives);
            player.TakeDamage(20);
            Console.WriteLine();
            Console.WriteLine("Health: " + player.health);
            Console.WriteLine("Shield: " + player.shield);
            Console.WriteLine("Lives: " + player.lives);


            Enemy enemySmall = new Enemy();
            Enemy enemyMedium = new Enemy();
            Enemy enemyLarge = new Enemy();
            Enemy enemyBoss = new Enemy();

            
            enemySmall.health = 10;
            enemySmall.name = "Rat";

            enemyMedium.health = 25;
            enemyMedium.name = "Bigger Rat";

            enemyLarge.health = 50;
            enemyLarge.name = "Even Bigger Rat";

            enemyBoss.health = 100;
            enemyBoss.name = "The Giant Rat Who Makes All of The Rules";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Name of enemy: " + enemySmall.name);
            Console.WriteLine("Health of enemy: " + enemySmall.health);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Name of enemy: " + enemyMedium.name);
            Console.WriteLine("Health of enemy: " + enemyMedium.health);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Name of enemy: " + enemyLarge.name);
            Console.WriteLine("Health of enemy: " + enemyLarge.health);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Name of enemy: " + enemyBoss.name);
            Console.WriteLine("Health of enemy: " + enemyBoss.health);








            Console.ReadKey(true);
        }
    }
}
