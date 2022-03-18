using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Print
    {
        public void PrintHerosStats(Hero hero, HealingPoition heal, ManaPoition mana) {
            Console.WriteLine("Here is your stats: ");
            Console.WriteLine("Health Points: " + hero.HP);
            Console.WriteLine("Mana amount: "+hero.HrsManaAmount);
            Console.WriteLine("Armor: "+hero.HrsArmour);
            Console.WriteLine("Attack Power: "+hero.HrsAtkPwr);
            Console.WriteLine("Level: "+hero.Level);
            Console.WriteLine("Experience: "+hero.Exp);
            Console.WriteLine("Vigor: "+hero.Vigor);
            Console.WriteLine("Strength: "+hero.Strength);
            Console.WriteLine("Dexterity: "+hero.Dexterity);
            Console.WriteLine("Intelligence: "+hero.Intelligence);
            Console.WriteLine("Your skill: " + hero.AbilityDescription);
            Console.WriteLine("You have {0} healing poitions and {1} mana poitions.", heal.Amount, mana.Amount);

            

        }

        public void PrintEnemyStats(Enemy enemy) {
            Console.WriteLine("Enemy`s name: " + enemy.Name);
            Console.WriteLine("Enemy`s skill: " + enemy.SkillDescription);
            Console.WriteLine("Enemy`s HP : " + enemy.Healh);
            Console.WriteLine("Enemy`s Mana Amount: " + enemy.Mana);
            Console.WriteLine("Enemy`s Attack Power: " + enemy.AttackPower);
            Console.WriteLine("Enemy`s Armor: " + enemy.Armor);
            Console.WriteLine("Enemy`s Magic Resistance: " + enemy.MagicResistance);
            Console.WriteLine("Experience for kill: " + enemy.ExpAmount);

         
        }
        public void PrintTutorial() {
            Console.WriteLine("Суть игры заключается в пошаговом сражении с противником, получении опыта, прокачки уровня, покупки предметов, то есть - самая обычная рпг");
            Console.WriteLine("Боевая система очень простая, расскажу про навыки: vigor - это максимальное ХП и резист к магическому демеджу(да да, тут есть виды урона)");
            Console.WriteLine("Dexterity - увеличивает количество брони(то есть физ. резист). Strength - увеличивает силу удара. Int - магический урон и кол-ва маны");
            Console.WriteLine("Accurance - навык, который есть у всех персонажей в игре, он отвечает за вероятность попадания по противнику физической атакой!");
            Console.WriteLine("Сейчас в игре нет режима PvP или Бот против Бота, но скоро будет");
            Console.WriteLine("Ах да, так как эта игра, названия из неё и тд вдохновлены souls-like`ом, то я описал не все механики :), удачи");
            ;
        }
    }
}
