using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class BossFightcs
    {
        Abilities ability = new Abilities();
        Attack attack = new Attack();
        LevelUp levelUp = new LevelUp();
        Enemy enemy = new Enemy();
        EnemyTurn enemyTurn = new EnemyTurn();
        HealingPoition heal = new HealingPoition();
        ManaPoition mana = new ManaPoition();
        Print print = new Print();
        public void BossFigth(Hero hero, string choice, Enemy enemy)
        {
            int enemydefenition = 666;
            enemy = new Boss();
            Console.WriteLine("You are fighting with the BOSS");
            while (true)
            {
                string actionChoise = "0";
                do
                {
                    Console.WriteLine("Press 1 for Attack, press 2 for ability, press 3 for using healing poition, press 4 for using mana poition, press 5 for overview");
                    if (hero.HrsManaAmount < ability.ManaCost) { Console.WriteLine("Be careful, you don`t have enough mana for you ability"); }
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
                        Console.WriteLine("You beat the boss, congratilations!");
                        hero.Gold += enemy.BonusGold;
                        break;
                    }
                    enemyTurn.EnemyAction(enemy, hero, enemydefenition);
                    if (hero.HP <= 0) { Console.WriteLine("YOU DIED"); break; }
                }

                else if (actionChoise == "2")
                {
                    hero.UseSkill(hero, choice, enemy);
                    if (enemy.Healh <= 0)
                    {
                        hero.Exp += enemy.ExpAmount;
                        levelUp.LvlUP(hero, enemy);
                        Console.WriteLine("You beat the boss, congratilations!");
                        hero.Gold += enemy.BonusGold;
                        break;
                    }
                    enemyTurn.EnemyAction(enemy, hero, enemydefenition);
                    if (hero.HP <= 0) { Console.WriteLine("YOU DIED"); break; }
                    
                }

                else if (actionChoise == "3")
                {
                    hero.UseHealingPoition(hero, heal);
                }
                else if (actionChoise == "4")
                {
                    hero.UseManaPoition(hero, mana);

                }
                else if (actionChoise == "5")
                {
                    print.PrintHerosStats(hero, heal, mana);
                    print.PrintEnemyStats(enemy);

                }






            }

        }
    }
}
