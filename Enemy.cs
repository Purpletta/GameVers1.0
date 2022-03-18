using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    class Enemy
    {
        public int BonusGold;
        public int MaxAttackPower;
        public int Healh;
        public int MaxHealth;
        public int AttackPower;
        public int ExpAmount;
        public int Mana;
        public int Armor;
        public int MaxArmor;
        public int MagicResistance;
        public int MaxMagicResistance;
        public int Accurancy;
        public string Name;
        public string SkillDescription;


    }
    class EnemyMage : Enemy
    {
        

        public EnemyMage()
        {   Name = "Mage";
            BonusGold = 3;
            Healh = 15;
            MaxHealth = 15;
            AttackPower = 4;
            MaxAttackPower = 4;
            ExpAmount = 100;
            Mana = 10;
            Armor = 1;
            MaxArmor = 1;
            MagicResistance = 5;
            MaxMagicResistance = 5;
            Accurancy = 80;
            SkillDescription = ("Deals 7 magic damage to hero.");


        }
        public void EnemyUseMageSkill(Enemy enemy, Hero hero, EnemyMageSkill skill)
        {

            if (enemy.Mana >= skill.Manacost)
            {Console.WriteLine("Mage uses his spell...");
                if (skill.Damage - hero.Vigor > 0)
                {
                    enemy.Mana -= skill.Manacost;
                    hero.HP -= (skill.Damage - hero.Vigor);
                    Console.WriteLine("You took {0} damage", skill.Damage - hero.Vigor);
                }
                else { Console.WriteLine("phew, you took 0 damage"); }

            }
            
        }
        public void EnemyUseMageVsBotSkill(Enemy enemy, Enemy enemy1, EnemyMageSkill skill)
        {

            if (enemy.Mana >= skill.Manacost)
            {
                Console.WriteLine("Mage uses his spell...");
                if (skill.Damage - enemy1.MagicResistance> 0)
                {
                    enemy.Mana -= skill.Manacost;
                    enemy1.Healh -= (skill.Damage - enemy1.MagicResistance);
                    Console.WriteLine("Enemy took {0} damage", skill.Damage - enemy1.MagicResistance);
                }
                else { Console.WriteLine("phew, he took 0 damage"); }

            }

        }

    }
    class EnemyOgre : Enemy
    {
        public EnemyOgre()
        {
            BonusGold = 4;
            SkillDescription = "Deals 8 physical damage to hero and restores 5 health to himself.";
            Healh = 20;
            MaxHealth = 20;
            AttackPower = 5;
            MaxAttackPower = 5;
            ExpAmount = 150;
            Mana = 6;
            Armor = 2;
            MaxArmor = 2;
            MagicResistance = 2;
            MaxMagicResistance = 2;
            Accurancy = 85;
            Name = "Ogre";
        }
        public void EnemyUseOgreSkill(Enemy enemy, Hero hero, EnemyOgreSkill skill)
        {
            if (enemy.Mana >= skill.Manacost)
            { if (enemy.Healh + 5 <= enemy.MaxHealth)
                {
                    Console.WriteLine("Ogre uses his spell...");
                    if (skill.Damage - hero.HrsArmour > 0)
                    {
                        enemy.Mana -= skill.Manacost;
                        hero.HP -= (skill.Damage - hero.HrsArmour);
                        Console.WriteLine("You took {0} damage and enemy have restored 5 health", skill.Damage - hero.HrsArmour);
                        if (enemy.MaxHealth != enemy.Healh)
                        {
                            if (enemy.Healh <= 15)
                            {
                                enemy.Healh += 5;
                            }
                            else { enemy.Healh = enemy.MaxHealth; }


                        }
                    } else { Console.WriteLine("Ogre dealt 0 damage to your because of your resistance :)"); }
                }

               
                //else normal attack
            }

        }
        public void EnemyVsEnemyUseOgreSkill(Enemy enemy, Enemy enemy1, EnemyOgreSkill skill)
        {
            if (enemy.Mana >= skill.Manacost)
            {
                Console.WriteLine("Ogre uses his spell...");
                if (skill.Damage - enemy1.Armor > 0)
                {
                    enemy.Mana -= skill.Manacost;
                    enemy1.Healh -= (skill.Damage - enemy1.Armor);
                    Console.WriteLine("Enemy {0} damage and enemy have restored 5 health", skill.Damage - enemy1.Armor);
                    if (enemy.MaxHealth != enemy.Healh)
                    {
                        if (enemy.Healh <= 15)
                        {
                            enemy.Healh += 5;
                        }
                        else { enemy.Healh = enemy.MaxHealth; }


                    }
                }
                else { Console.WriteLine("Ogre dealt 0 damage to enemy because of resistance :)"); }
                
            }

        }

    }
        class EnemyTrickster : Enemy
        {
            public EnemyTrickster()//dodger 
            {
            BonusGold = 5;
            Healh = 10;
                MaxHealth = 10;
                AttackPower = 6;
                MaxAttackPower = 6;
                ExpAmount = 300;
                Mana = 8;
                Armor = 3;
                MaxArmor = 3;
                MagicResistance = 3;
                MaxMagicResistance = 3;
                Accurancy = 90;
                Name = "Trickster";
                SkillDescription = "Deals 2 pure damage to hero and dicreases his accurance by 20";
        }
            public void EnemyUseTricksterSkill(Enemy enemy, Hero hero, EnemyTricksterAbility skill)
            {
                if (enemy.Mana >= skill.Manacost)
                {
                    Console.WriteLine("Trickster uses his spell...");
                    enemy.Mana -= skill.Manacost;
                    hero.HP -= skill.Damage;
                    hero.Accurance -= 20;
                    Console.WriteLine("You took {0} damage and your accurancy reduced by 30",skill.Damage);
                }
                

            }
        public void EnemyVsEnemyUseTricksterSkill(Enemy enemy, Enemy enemy1, EnemyTricksterAbility skill)
        {
            if (enemy.Mana >= skill.Manacost)
            {
                Console.WriteLine("Trickster uses his spell...");
                enemy.Mana -= skill.Manacost;
                enemy1.Healh-= skill.Damage;
                enemy1.Accurancy -= 20;
                Console.WriteLine("Enemy took {0} damage and his accurancy reduced by 30", skill.Damage);
            }


        }
    }



        class EnemyHealer : Enemy
        {
            public EnemyHealer()
            {
            BonusGold = 4;
            Healh = 17;
                MaxHealth = 17;
                AttackPower = 4;
                MaxAttackPower = 4;
                ExpAmount = 200;
                Mana = 12;
                Armor = 2;
                MaxArmor = 2;
                MagicResistance = 2;
                MaxMagicResistance = 2;
                Accurancy = 100;
                Name = "Cliric";
                SkillDescription = "Restores 10 health for himself.";
        }

            public void EnemyUseHealerSkill(Enemy enemy, Hero hero, EnemyHealerAbility skill)
            {
                if (enemy.Mana >= skill.Manacost)
                {
                    Console.WriteLine("Cliric uses his spell...");
                
                    if ( enemy.Healh+skill.Damage<=enemy.MaxHealth)
                    {
                           Console.WriteLine("Cliric restored {0} HP",skill.Damage);
                            enemy.Mana -= skill.Manacost;
                            enemy.Healh += skill.Damage;
                            
                        
                        
                    } else { enemy.Mana -= skill.Manacost; enemy.Healh = enemy.MaxHealth; Console.WriteLine("Cliric fully regained his HP"); }
                } 

            }
        public void EnemyVsEnemyUseHealerSkill(Enemy enemy, EnemyHealerAbility skill)
        {
            if (enemy.Mana >= skill.Manacost)
            {
                Console.WriteLine("Cliric uses his spell...");

                if (enemy.Healh + skill.Damage <= enemy.MaxHealth)
                {
                    Console.WriteLine("Cliric restored {0} HP", skill.Damage);
                    enemy.Mana -= skill.Manacost;
                    enemy.Healh += skill.Damage;



                }
                else { enemy.Mana -= skill.Manacost; enemy.Healh = enemy.MaxHealth; Console.WriteLine("Cliric fully regained his HP"); }
            }

        }

    }

    class Boss : Enemy
    {




        public Boss()
        {
            BonusGold = 50;
            Healh = 40;
            MaxHealth = 40;
            AttackPower = 10;
            MaxAttackPower = 10;
            ExpAmount = 1000;
            Mana = 20;
            Armor = 6;
            MaxArmor = 6;
            MagicResistance = 6;
            MaxMagicResistance = 6;
            Accurancy = 70;
            Name = "Boss";
            SkillDescription = "Debuffs hero characteristics (accurance by 5, armor by 1) and deals 3 damage";

        }

        public void EnemyUseBossSkill(Enemy enemy, Hero hero, BossAbility skill) {
            if (enemy.Mana >= skill.Manacost) {
                Console.WriteLine("Boss uses his speal...");
                enemy.Mana -= skill.Manacost;
                hero.Accurance -= 5;
                hero.HrsArmour -= 1;
                if (hero.HrsArmour < 0) { hero.HrsArmour = 0; }
                if (skill.Damage - hero.HrsArmour > 0)
                {
                    hero.HP -= (skill.Damage - hero.HrsArmour);
                    Console.WriteLine("Your accurance was reduced by 5, armor by 1, you took {0} damage", skill.Damage - hero.HrsArmour);
                }
                else { Console.WriteLine("Your accurance was reduced by 5, armor by 1"); }
            
            }
        
        
        
        }


    }



}

