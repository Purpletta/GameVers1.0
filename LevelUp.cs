using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class LevelUp
    { public void LvlUP(Hero hero, Enemy enemy) {
            if (hero.Exp >= 1000)
            {
                Console.WriteLine("You have raised your level. Now, you can improve one of your attributes");

                string choice = "0";
                do
                {

                    Console.WriteLine("1 - Vigor. 2 - Dexterity. 3 - Strength. 4 - Intelligence.");
                    choice = Console.ReadLine();
                } while (choice != "1" && choice != "2" && choice != "3" && choice != "4");
                if (choice == "1") { hero.Vigor += 1; }
                else if (choice == "2") { hero.Dexterity += 1; }
                else if (choice == "3") { hero.Strength += 1; }
                else if (choice == "4") { hero.Intelligence += 1; }
                Console.WriteLine("You have become stronger, but so have your enemies...");
                enemy.AttackPower += 2;enemy.MaxHealth += 2; enemy.Healh += 2; enemy.ExpAmount += 100; enemy.Armor += 1;
            }
            else { return; }
        
        }
    public void Rage(Enemy enemy) {
            Console.WriteLine("Enemy have strengthen...");
            enemy.AttackPower += 1;
            enemy.MagicResistance += 1;
            enemy.Armor += 1;

    
    
    } }
   
}
