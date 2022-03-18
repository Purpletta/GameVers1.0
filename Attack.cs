using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Attack
    {   public void HeroUseNormalAttack(Hero hero, Enemy enemy) {
            Random rnd = new Random();
            int attacksuccess = rnd.Next(0, 101);
            if (hero.Accurance >= attacksuccess)
            {
                if (hero.HrsAtkPwr - enemy.Armor <= 0)
                {
                    Console.WriteLine("Bronya ne probita");
                }
                else
                {
                    enemy.Healh -= (hero.HrsAtkPwr - enemy.Armor);
                    Console.WriteLine("you have dealt {0} damage", hero.HrsAtkPwr - enemy.Armor);
                }
            }
            else { Console.WriteLine("Oops, you missed"); } 
        }
        public void EnemyUseNormalAttack(Hero hero, Enemy enemy) {
            Random rnd = new Random();
            int attacksuccess = rnd.Next(1, 101);
            if (enemy.Accurancy >= attacksuccess+hero.DodgeChance)
            {
                if (enemy.AttackPower - hero.HrsArmour <= 0) { Console.WriteLine("Bronya ne probita"); }
                else
                {
                    hero.HP -= (enemy.AttackPower - hero.HrsArmour);
                    Console.WriteLine("You took {0} damage", enemy.AttackPower - hero.HrsArmour);
                }
            }
            else { Console.WriteLine("You dodged an enemy strike "); }
        
        }
        Random rnd = new Random();
        public void EnemyVsEnemyNormalAttack(Enemy enemy, Enemy enemy1)
        {

            int attacksuccess = rnd.Next(1, 101);
            if (enemy.Accurancy >= attacksuccess)
            {
                if (enemy.AttackPower - enemy1.Armor <= 0) { Console.WriteLine("Bronya ne probita"); }
                else
                {
                    enemy1.Healh -= (enemy.AttackPower - enemy1.Armor);
                    Console.WriteLine("Enemy{0} dealt {1} damage",enemy.Name, enemy.AttackPower - enemy1.Armor);
                }
            }
            else { Console.WriteLine("Enemy2 dodged strike"); }

        }

        


    }
}
