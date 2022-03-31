using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Battle
    {
        public void Run(Hero hero, string choice) {
            Enemy enemy = new Enemy();
            Print print = new Print();
            Random rnd = new Random();
            Attack attack = new Attack();
            EnemyAbility enemyability = new EnemyAbility();
            HealingPoition heal = new HealingPoition();
            ManaPoition mana = new ManaPoition();
            EnemyAbility enemyAbility = new EnemyAbility();
            Abilities ability = new Abilities();
            EnemyTurn enemyTurn = new EnemyTurn();
            LevelUp levelUp = new LevelUp();
            Fixing fixing = new Fixing();
            Camp camp = new Camp();
            
            int enemydefinition = rnd.Next(1, 5);
            if (enemydefinition == 1) {
                enemy = new EnemyMage();
                Console.WriteLine("You are fighiting with {0}", enemy.Name);
                print.PrintEnemyStats(enemy);
            }
            if (enemydefinition == 2) {
                enemy = new EnemyOgre();
                Console.WriteLine("You are fighiting with {0}", enemy.Name);
                print.PrintEnemyStats(enemy);
            }
            if (enemydefinition == 3) {
                enemy = new EnemyTrickster();
                Console.WriteLine("You are fighiting with {0}", enemy.Name);
                print.PrintEnemyStats(enemy);
            }
            if (enemydefinition == 4) {
                enemy = new EnemyHealer();
                Console.WriteLine("You are fighiting with {0}", enemy.Name);
                print.PrintEnemyStats(enemy);

            }
            
            while (true) {
                string actionChoise = "0";
                do
                {    Console.WriteLine("Press 1 for Attack, press 2 for ability, press 3 for using healing poition, press 4 for using mana poition, press 5 for overview");
                    
                    actionChoise = (Console.ReadLine());
                }
                while (actionChoise != "1" && actionChoise != "2" && actionChoise != "3" && actionChoise != "4" && actionChoise != "5");
                if (actionChoise == "1")
                {
                    attack.HeroUseNormalAttack(hero, enemy);
                    if (enemy.Healh <= 0)
                    {
                        hero.Exp += enemy.ExpAmount;
                        levelUp.LvlUP(hero, enemy);
                        Console.WriteLine("You won the battle, congratilations!");
                            hero.Gold+=enemy.BonusGold;
                        break;
                    }
                    enemyTurn.EnemyAction(enemy, hero,enemydefinition);
                    if (hero.HP <= 0) { Console.WriteLine("YOU DIED"); break; }
                   }
                
                else if (actionChoise == "2")
                    {
                    hero.UseSkill(hero,choice,enemy);
                    if (enemy.Healh <= 0) {
                  hero.Exp += enemy.ExpAmount;
                  levelUp.LvlUP(hero, enemy);
                  Console.WriteLine("You won the battle, congratilations!");
                        hero.Gold += enemy.BonusGold;
                        break;
                    }
                    enemyTurn.EnemyAction(enemy, hero, enemydefinition);
                    if (hero.HP <= 0) { Console.WriteLine("YOU DIED"); break; }
                  levelUp.Rage(enemy);  }
                
                else if (actionChoise == "3")
                    {
                    hero.UseHealingPoition(hero, heal);
                    }
                else if (actionChoise == "4")
                    {
                    hero.UseManaPoition(hero, mana);

                    }
                else if (actionChoise == "5") {
                    print.PrintHerosStats(hero, heal, mana);
                    print.PrintEnemyStats(enemy);

                    }





                


            }
            fixing.GetFixed(hero, enemy);
            Console.WriteLine("Do you want to battle again?");
            string buttonForRestart = "0";
            do
            {
                Console.WriteLine("1 - battle again. 2 - go to camp. 3 - exit from game");
                buttonForRestart = Console.ReadLine();

            } while (buttonForRestart != "1" && buttonForRestart != "2" && buttonForRestart != "3");
            if (buttonForRestart == "1") {
                Run(hero, choice);
            }
            else if (buttonForRestart == "2") {

                camp.CampLocation(hero,choice);
            }
            else if (buttonForRestart == "3") {
                Console.WriteLine("Bye bye, thanks for game");
                }


            
        
        }




    }
}
