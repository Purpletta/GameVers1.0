using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Abilities
    {
        public int ManaCost;
        public int SkillLevel;
        public int SkillExp;
        public string Description;
        
        }
    


    class DragonSlave : Abilities
    {

        public int damage = 8;
        public DragonSlave()
        {
            ManaCost = 6;
            SkillLevel = 1;
            SkillExp = 0;
            Description = "Channels the breath of a dragon, sending out a wave of fire that scorches every enemy in its path. Damage per level: 8/10/12/14. Manacost : 6/7/9/12";

        }
        

    }

    class StiflingDagger : Abilities
    {
        public int damage = 5;
        public StiflingDagger()
        {
            ManaCost = 4;
            SkillLevel = 1;
            SkillExp = 0;
            Description = "Throws a dagger dealing damage depending on the dexterity of the character. Also increases target damage by 3/4/5/6. Damage per level : 5/6/7/8. Manacost : 4/5/6/6";


        }
       



    }
    class ArmorUp : Abilities
    {
        public int armor = 1;
        public ArmorUp()
        {
            ManaCost = 5;
            SkillLevel = 1;
            SkillExp = 0;
            Description = "The life blood of the Dragon strengthens armor by 1/2/3/4. Manacost : 5/6/7/9";


        }
        

    }

    class Thirst : Abilities
    {
        public int AttackBonus;
        public int HealthCost;

        public Thirst()
        {
            HealthCost = 4;
            AttackBonus = 5;
            ManaCost = 0;
            SkillLevel = 1;
            SkillExp = 0;
            Description = "Deals damage to himself to increase his attack. Spends health, not mana. Damage by itself : 4/5/6/7. Attack bonus: 5/7/9/11";



        }
        


    }
    class EnemyAbility
    {
        public int Damage;
        public int Manacost;
        public string Description;






    }
    class EnemyMageSkill : EnemyAbility
    {
        public EnemyMageSkill()
        {
            Damage = 7;
            Manacost = 5;
            Description = "Deals 7 magic damage to hero.";



        }

    }
    class EnemyOgreSkill : EnemyAbility
    {
        public EnemyOgreSkill()
        {
            Damage = 8;
            Manacost = 3;
            Description = "Deals 8 physical damage to hero and restores 5 health to himself.";
        }


    }
    class EnemyTricksterAbility : EnemyAbility
    {
        public EnemyTricksterAbility()
        {
            Damage = 2;
            Manacost = 4;
            Description = "Deals 2 pure damage to hero and dicreases his accurance by 20";



        }

    }
    class EnemyHealerAbility : EnemyAbility
    {
        public EnemyHealerAbility()
        {
            Damage = 10;
            Manacost = 6;
            Description = "Restores 10 health for himself.";

        }

    }
    class BossAbility : EnemyAbility  {
        public BossAbility() {
            Damage = 4;
            Manacost = 5;
        }
    
    
    }




}
