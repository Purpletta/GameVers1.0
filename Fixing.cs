using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Fixing
    { public void GetFixed(Hero hero, Enemy enemy) {
            hero.HP = hero.MaxHP;
            hero.HrsManaAmount = hero.MaxMana;
            hero.Accurance = hero.MaxAccurance;
            hero.HrsArmour = hero.MaxArmor;
            hero.HrsAtkPwr = hero.MaxAttack;
            enemy.Armor = enemy.MaxArmor;
            enemy.Healh = enemy.MaxHealth;
            enemy.AttackPower = enemy.MaxAttackPower;
            enemy.MagicResistance = enemy.MaxMagicResistance;
        
        }
        



    }
}
