using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class BotvsBot
    {
        
        
        
        
        Enemy enemy = new Enemy();
        Enemy enemy1 = new Enemy();
        EnemyTurn turn = new EnemyTurn();
        Random rnd = new Random();
        public void BvBRun()
        {
            int enemydefinition = rnd.Next(1, 5);
            if (enemydefinition == 1)
            {
                enemy = new EnemyMage();
                Console.WriteLine("First fighter is {0}", enemy.Name);

            }
            if (enemydefinition == 2)
            {
                enemy = new EnemyOgre();
                Console.WriteLine("First fighter is {0}", enemy.Name);

            }
            if (enemydefinition == 3)
            {
                enemy = new EnemyTrickster();
                Console.WriteLine("First fighter is {0}", enemy.Name);

            }
            if (enemydefinition == 4)
            {
                enemy = new EnemyHealer();
                Console.WriteLine("First fighter is {0}", enemy.Name);
            
            }

            int enemydefinition1 = rnd.Next(1, 5);
            if (enemydefinition1 == 1)
            {
                enemy1 = new EnemyMage();
                Console.WriteLine("Secons fighter is {0}", enemy1.Name);

            }
            if (enemydefinition1 == 2)
            {
                enemy1 = new EnemyOgre();
                Console.WriteLine("Secons fighter is {0}", enemy1.Name);

            }
            if (enemydefinition1 == 3)
            {
                enemy1 = new EnemyTrickster();
                Console.WriteLine("Secons fighter is {0}", enemy1.Name);

            }
            if (enemydefinition1 == 4)
            {
                enemy1 = new EnemyHealer();
                Console.WriteLine("Secons fighter is {0}", enemy1.Name);

            }
            Console.WriteLine("Let`s the AI battle start");
            while (enemy.Healh >= 0 || enemy1.Healh >= 0)
            {
                turn.EnemyBotbsVsBotAction(enemy, enemydefinition, enemy1, enemydefinition1);
                if (enemy1.Healh <= 0) { Console.WriteLine("enemy 1 won"); break; }
                turn.EnemyBotbsVsBotAction(enemy1, enemydefinition1, enemy, enemydefinition);
                if (enemy.Healh <= 0) { Console.WriteLine("enemy 2 won"); break; }
                
            }
            Console.WriteLine("We have the winner");




        }

    }
}
