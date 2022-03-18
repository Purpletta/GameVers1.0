using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class EnemyTurn
    { Boss boss = new Boss();
            BossAbility bossAbility = new BossAbility();
            EnemyMage mage = new EnemyMage();
            EnemyOgre ogre = new EnemyOgre();
            EnemyTrickster trickster = new EnemyTrickster();
            EnemyHealer healer = new EnemyHealer();
            EnemyMageSkill skill = new EnemyMageSkill();
            EnemyOgreSkill ogreSkill = new EnemyOgreSkill();
            EnemyTricksterAbility tricksterAbility = new EnemyTricksterAbility();
            EnemyHealerAbility healerAbility = new EnemyHealerAbility();
            Attack attack = new Attack();
        public void EnemyAction(Enemy enemy, Hero hero, int choice)
        {
           
            if (choice == 1)
            {
                if (enemy.Mana >= skill.Manacost)
                {
                    mage.EnemyUseMageSkill(enemy, hero, skill);

                }
                else { attack.EnemyUseNormalAttack(hero, enemy); }
            }
            else if (choice == 2)
            {
                if (ogreSkill.Manacost <= enemy.Mana)
                {
                    ogre.EnemyUseOgreSkill(enemy, hero, ogreSkill);
                }
                else { attack.EnemyUseNormalAttack(hero, enemy); } 



            }
            else if (choice == 3)
            {
                if (enemy.Mana >= tricksterAbility.Manacost)
                {
                    trickster.EnemyUseTricksterSkill(enemy, hero, tricksterAbility);
                }
                else { attack.EnemyUseNormalAttack(hero, enemy); }

            }
            else if (choice == 4)
            {

                if (enemy.Mana >= healerAbility.Manacost)
                {
                    if (enemy.Healh + 5 <= enemy.MaxHealth)
                    {
                        healer.EnemyUseHealerSkill(enemy, hero, healerAbility); ;
                    }
                    else { attack.EnemyUseNormalAttack(hero, enemy); }
                }
                else { attack.EnemyUseNormalAttack(hero, enemy); }


            }
            else if (choice == 666) {
                if (enemy.Mana >= bossAbility.Manacost)
                {
                    boss.EnemyUseBossSkill(enemy, hero, bossAbility);


                }
                else { attack.EnemyUseNormalAttack(hero, enemy); }
            
            
            }
        }
        public void EnemyBotbsVsBotAction(Enemy enemy, int choice, Enemy enemy1, int choice1)
        {
            
            if (choice == 1)
            {
                if (enemy.Mana >= skill.Manacost)
                {
                    mage.EnemyUseMageVsBotSkill(enemy, enemy1, skill);
                    if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); }

                }
                else { attack.EnemyVsEnemyNormalAttack(enemy, enemy1); if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); } }
            }
            else if (choice == 2)
            {
                if (enemy.Mana >= ogreSkill.Manacost)
                {
                    if (enemy.MaxHealth >= enemy.Healh + 5)
                    {
                        ogre.EnemyVsEnemyUseOgreSkill(enemy, enemy1, ogreSkill);
                        if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); }

                 }
                }
                else { attack.EnemyVsEnemyNormalAttack(enemy, enemy1); if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); } }



            }
            else if (choice == 3)
            {
                if (enemy.Mana >= tricksterAbility.Manacost)
                {
                    trickster.EnemyVsEnemyUseTricksterSkill(enemy, enemy1, tricksterAbility);
                    if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); }
                }
                else { attack.EnemyVsEnemyNormalAttack(enemy, enemy1); if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); } }

            }
            else if (choice == 4)
            {

                if (enemy.Mana >= healerAbility.Manacost)
                {
                    if (enemy.Healh + 5 <= enemy.MaxHealth)
                    {
                        healer.EnemyVsEnemyUseHealerSkill(enemy, healerAbility);
                    }
                }
                else
                {
                    attack.EnemyVsEnemyNormalAttack(enemy, enemy1); if (enemy1.Healh <= 0) { Console.WriteLine("Pobeda"); }


                }

            }







        }
    }
}
