using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    class Hero
    {
        public int Gold;
        public int HP;
        public int MaxHP;
        public int HrsAtkPwr;
        public int MaxAttack;
        public int HrsManaAmount;
        public int MaxMana;
        public int HrsArmour;
        public int MaxArmor;
        public int Level;
        public int Exp;
        public int Strength;
        public int Dexterity;
        public int Vigor;
        public int Intelligence;
        public string AbilityDescription;
        public int Accurance;
        public int MaxAccurance;
        public int DodgeChance;

        public void UseSkill(Hero hero,string choice, Enemy enemy) {
          
            Mage mage = new Mage();
            Rogue rogue = new Rogue();
            Warrior warrior = new Warrior();
            Berserker berserker = new Berserker();
            DragonSlave dragonSlave = new DragonSlave();
            StiflingDagger stiflingDagger = new StiflingDagger();
            ArmorUp armorUp = new ArmorUp();
            Thirst thirst = new Thirst();
            

            if (choice == "1")
            {
                mage.UseSkillDragonSlave(hero, enemy, dragonSlave);
            }
            else if (choice == "2")
            {
                rogue.UseSkillStiflingDagger(hero, enemy, stiflingDagger);

            }
            else if (choice == "3")
            {
                warrior.UseSkillArmorUp(hero, armorUp);
                
            }
            else if (choice == "4") {
                berserker.UseSkillThirst(hero, thirst);
                    
            }


        
        
        
        }
        public void UseHealingPoition(Hero hero, HealingPoition poition)
        {
            if (hero.MaxHP == hero.HP)
            {
                Console.WriteLine("Your HP is max. Can`t use more.");
            }
            else if (poition.Amount <= 0)
            {
                Console.WriteLine("You don`t have any healing poitions");
            }
            else
            {
                if (poition.Amplification + hero.HP > hero.MaxHP) { hero.HP = hero.MaxHP; Console.WriteLine("You have fully recovered your health"); }
                else
                {   
                    hero.HP += poition.Amplification;
                    poition.Amount--;
                    Console.WriteLine("You have regained {0} health", poition.Amplification);
                }
            }
        }

       

        public void UseManaPoition(Hero hero, ManaPoition poition)
        {
            if (hero.HrsManaAmount == hero.MaxMana)
            {
                Console.WriteLine("Your Mana is max. Can`t use more.");
            }
            else if (poition.Amount <= 0)
            {
                Console.WriteLine("You don`t have any mana poitions");
            }
            else
            {
                if (poition.Amplification + hero.HrsManaAmount > hero.MaxMana) { hero.HrsManaAmount = hero.MaxMana; Console.WriteLine("You have fully recovered your health"); }
                else
                {   
                    hero.HrsManaAmount += poition.Amplification;
                    poition.Amount--;
                    Console.WriteLine("You have regained {0} mana", poition.Amplification);
                }
            }

        }



        //public void UseSkill(string choice)
        //{
        //    if (choice == "1")
        //    {
        //       Abilities skill = new Abilities();
        //        skill = new DragonSlave();
        //        skill.UseDragonSlave();
        //        //void UseSkillDragonSlave(Mage mage, Enemy enemy, DragonSlave skill)
        //        //{
        //        //    if (mage.HrsManaAmount >= skill.ManaCost)
        //        //    {
        //        //        enemy.Healh -= (skill.damage + (mage.Intelligence * 1)) - enemy.MagicResistance;
        //        //        skill.SkillExp += 100;
        //        //        if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; if (skill.SkillLevel == 2) { skill.damage += 2; skill.ManaCost += 1; } if (skill.SkillLevel == 3) { skill.damage += 2; skill.ManaCost += 2; } else { skill.damage += 2; skill.ManaCost += 3; } skill.SkillExp = 0; }
        //        //    }
        //        //    else { Console.WriteLine("You don`t have enough mana"); }
        //        //}


        //    }
        //    else if (choice == "2")
        //    {
        //        void UseSkillStiflingDagger(Rogue rogue, Enemy enemy, StiflingDagger skill)
        //        {
        //            if (rogue.HrsManaAmount >= skill.ManaCost)
        //            {
        //                enemy.Healh -= (skill.damage + (rogue.Dexterity * 1)) - enemy.Armor;
        //                skill.SkillExp += 100;
        //                if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; skill.damage += 1; skill.ManaCost += 1; if (skill.ManaCost > 6) { skill.ManaCost = 6; } skill.SkillExp = 0; }
        //            }
        //            else { Console.WriteLine("You don`t have enough mana"); }
        //        }
        //    }
        //    else if (choice == "3")
        //    {
        //        void UseSkillArmorUp(Warrior warrior, ArmorUp skill)
        //        {
        //            if (warrior.HrsManaAmount >= skill.ManaCost)
        //            {
        //                warrior.HrsArmour += skill.armor;
        //                skill.SkillExp += 100;
        //                if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; skill.armor += 1; skill.ManaCost += 1; if (skill.SkillLevel == 3) { skill.ManaCost = 6; } skill.SkillExp = 0; }
        //            }
        //            else { Console.WriteLine("You don`t have enough mana"); }
        //        }

        //    }
        //    else if (choice == "4")
        //    {
        //        void UseSkillThirst(Berserker berserker, Thirst skill)
        //        {
        //            if (berserker.HP > skill.HealthCost)
        //            {
        //                berserker.HP -= skill.HealthCost;
        //                berserker.HrsAtkPwr += skill.AttackBonus;
        //                skill.SkillExp += 100;
        //                if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; skill.AttackBonus += 2; skill.HealthCost += 1; skill.SkillExp = 0; }
        //            }
        //            else if (berserker.HP <= skill.HealthCost)
        //            {
        //                berserker.HP -= skill.HealthCost;
        //                Console.WriteLine("You have killed yourself :)");

        //            }
        //        }
        //    }


        //}

    }


    class Mage : Hero
    {
        public Mage()
        {
            Gold = 0;
            MaxHP = 14;
            HP = 14;
            HrsAtkPwr = 4;
            MaxAttack = 4;
            HrsManaAmount = 16;
            MaxMana = 16;
            HrsArmour = 2;
            MaxArmor = 2;
            Level = 1;
            Exp = 0;
            Strength = 2;
            Dexterity = 1;
            Vigor = 2;
            Intelligence = 3;
            Accurance = 85;
            DodgeChance = 10;
            AbilityDescription = "Channels the breath of a dragon, sending out a wave of fire that scorches every enemy in its path. Damage per level: 6/8/10/12. Manacost : 6/7/9/12";
            MaxAccurance = 85;
            


        }


        public void UseSkillDragonSlave(Hero hero, Enemy enemy, DragonSlave skill)
        {   
            if (hero.HrsManaAmount >= skill.ManaCost)
            { if ((skill.damage + (hero.Intelligence * 1)) - enemy.MagicResistance > 0)
                {   
                    hero.HrsManaAmount -= skill.ManaCost;
                    enemy.Healh -= (skill.damage + (hero.Intelligence * 1)) - enemy.MagicResistance;
                    skill.SkillExp += 100;
                    Console.WriteLine("You dealt {0} damage to enemy", (skill.damage + (hero.Intelligence * 1)) - enemy.MagicResistance);
                    if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; if (skill.SkillLevel == 2) { skill.damage += 2; skill.ManaCost += 1; } if (skill.SkillLevel == 3) { skill.damage += 2; skill.ManaCost += 2; } else { skill.damage += 2; skill.ManaCost += 3; } skill.SkillExp = 0; }
                }
                else { Console.WriteLine("Your magic is sooooo week, you dealt 0 damage");}
                 }
            else { Console.WriteLine("You don`t have enough mana, I told you..."); }
        }


    }
    class Rogue : Hero
    {
        public Rogue()
        {
            Gold = 0;
            MaxHP = 14;
            HP = 14;
            HrsAtkPwr = 6;
            MaxAttack = 6;
            HrsManaAmount = 12;
            MaxMana = 12;
            HrsArmour = 3;
            MaxArmor = 3;
            Level = 1;
            Exp = 0;
            Strength = 2;
            Dexterity = 3;
            Vigor = 2;
            Intelligence = 2;
            Accurance = 90;
            DodgeChance = 20;
            AbilityDescription = "Throws a dagger dealing damage depending on the dexterity of the character. Also this skill can cause crtitical damage equal to your characters`s double attack. Manacost : 4/5/6/6";
            MaxAccurance = 90;
        }
        public void UseSkillStiflingDagger(Hero hero, Enemy enemy, StiflingDagger skill)
        {
            Random rnd = new Random();
            int criticalChance = 10;
            if (hero.HrsManaAmount >= skill.ManaCost)
            {
                int criticalResult = rnd.Next(1, 101);
                if (criticalResult <= criticalChance)
                {
                    enemy.Healh -= 2 * hero.HrsAtkPwr - enemy.Armor;
                    Console.WriteLine("That was a critical strike!, you dealt {0} damage", 2 * hero.HrsAtkPwr - enemy.Armor);
                }
                else if  (((skill.damage + (hero.Dexterity * 1)) - enemy.Armor > 0) && (criticalResult>criticalChance) )
                {
                    hero.HrsManaAmount -= skill.ManaCost;
                    enemy.Healh -= (skill.damage + (hero.Dexterity * 1)) - enemy.Armor;

                    skill.SkillExp += 100;
                    Console.WriteLine("You dealt {0} damage to enemy", (skill.damage + (hero.Dexterity * 1)) - enemy.Armor);
                    if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; skill.damage += 1; skill.ManaCost += 1; if (skill.ManaCost > 6) { skill.ManaCost = 6; } skill.SkillExp = 0; }
                }
                else { Console.WriteLine("Haha, your dagger did 0 damage because someone forgot to shapren it ;)"); }
            }
            else { Console.WriteLine("You don`t have enough mana");  }
        }

    }
    class Warrior : Hero
    {
        public Warrior()
        {
            Gold = 0;
            MaxHP = 17;
            HP = 17;
            HrsAtkPwr = 7;
            MaxAttack = 7;
            HrsManaAmount = 10;
            MaxMana = 10;
            HrsArmour = 5;
            MaxArmor = 5;
            Level = 1;
            Exp = 0;
            Strength = 3;
            Dexterity = 2;
            Vigor = 2;
            Intelligence = 2;
            Accurance = 80;
            DodgeChance = 5;
            AbilityDescription = "The life blood of the Dragon strengthens armor by 1/2/3/4. Manacost : 5/6/7/9";
            MaxAccurance = 80;
        }
        public void UseSkillArmorUp(Hero hero, ArmorUp skill)
        {
            if (hero.HrsManaAmount >= skill.ManaCost)
            {
                hero.HrsManaAmount -= skill.ManaCost;
                hero.HrsArmour += skill.armor;
                skill.SkillExp += 100;
                Console.WriteLine("You gained {0} armor", skill.armor);
                if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; skill.armor += 1; skill.ManaCost += 1; if (skill.SkillLevel == 3) { skill.ManaCost = 6; } skill.SkillExp = 0; }
            }
            else { Console.WriteLine("You don`t have enough mana"); }
        }

    }
    class Berserker : Hero
    {
        public Berserker()
        {
            Gold = 0;
            MaxHP = 20;
            HP = 20;
            HrsAtkPwr = 3;
            MaxAttack = 3;
            HrsManaAmount = 1;
            MaxMana = 1;
            HrsArmour = 1;
            MaxArmor = 1;
            Level = 1;
            Exp = 0;
            Strength = 2;
            Dexterity = 2;
            Vigor = 4;
            Intelligence = 1;
            Accurance = 80;
            DodgeChance = 1;
            AbilityDescription = "Deals damage to himself to increase his attack. Spends health, not mana. Damage by itself : 4/5/6/7. Attack bonus: 5/7/9/11";
            MaxAccurance = 80;


        }
        public void UseSkillThirst(Hero hero, Thirst skill)
        {
            if (hero.HP > skill.HealthCost)
            {
                hero.HP -= skill.HealthCost;
                hero.HrsAtkPwr += skill.AttackBonus;
                skill.SkillExp += 100;
                Console.WriteLine("You lost {0} HP but gained {1} attack", skill.HealthCost, skill.AttackBonus);
                if (skill.SkillExp >= 1000) { Console.WriteLine("You have raised the skill level"); skill.SkillLevel += 1; skill.AttackBonus += 2; skill.HealthCost += 1; skill.SkillExp = 0; }
            }
            else if (hero.HP <= skill.HealthCost)
            {
                hero.HP -= skill.HealthCost;
                Console.WriteLine("You have killed yourself :)");

            }
        }
    }
}


