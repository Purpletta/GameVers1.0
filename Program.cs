using System;

namespace Game
{
    class Program
    {
        public static void Main()
        {
            
            string modeChoice = "0";
            do {Console.WriteLine("2 - PvE. 3 - Bot vs Bot"); modeChoice = Console.ReadLine();  } while (modeChoice != "1" && modeChoice != "2" && modeChoice != "3");
            

             if (modeChoice == "2")
            {
                Console.WriteLine("OK");
            }
            else if (modeChoice == "3") { Console.WriteLine("Mkay"); BotvsBot botvsBot = new BotvsBot(); botvsBot.BvBRun(); System.Environment.Exit(1); }
            
            Console.WriteLine("Game starts, you need to choose your class: mage, rogue, warrior, berserker");
            Console.WriteLine("The mage deals a ton of damage(especially at late game), but his armor and health leave much to be desired");
            Console.WriteLine("Warrior is a walking rock that not everyone can break through, but his damage is quite small ");
            Console.WriteLine("Rogue is an extraordinarily dexterous character relying on his resourcefulness and accuracy.Main disadvantage is health");
            Console.WriteLine("Berserker is a difficult character, because his initial damage is very low, but over time it can reach gigantic values");
            string choice = "0";
            do
            {
                Console.WriteLine("1 - Mage. 2 - Rogue. 3 - Warrior. 4 - Berserker.");
                choice = Console.ReadLine();
            } while (choice != "1" && choice != "2" && choice != "3" && choice != "4");
            Hero hero = new Hero();
            if (choice == "1") { hero = new Mage(); }
            else if (choice == "2") { hero = new Rogue(); }
            else if (choice == "3") { hero = new Warrior(); }
            else if (choice == "4") { hero = new Berserker(); } 
            Print print = new Print();
            HealingPoition salve = new HealingPoition();
            ManaPoition clarity = new ManaPoition();
            print.PrintTutorial();
            print.PrintHerosStats(hero,salve, clarity);
            Battle battle = new Battle();
            battle.Run(hero,choice);
            
        }
    } 
}
