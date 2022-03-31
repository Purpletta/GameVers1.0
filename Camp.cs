using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Camp
    { public void CampLocation(Hero hero, string campChoice) {
     Console.WriteLine("Добро пожаловать в лагерь, здесь вы можете отдохнуть, а также приобрести новые предметы");
            Camp camp = new Camp();
            Rest rest = new Rest();
            Battle battle = new Battle();
            BossFightcs bossFightcs = new BossFightcs();
            Boss boss = new Boss();
            string choice = "0";
            do
            {
                Console.WriteLine("Чтобы отдохнуть - нажмите 1. Чтобы посмотреть список предметов - нажмите 2. Бой с боссом - 4. 5 - обратно в бой");
                choice = Console.ReadLine();


            } while (choice != "1" && choice != "2"  && choice != "4" && choice!="5");
            if (choice == "1")
            {
                rest.ReadJokes();
                camp.CampLocation(hero, campChoice);


            }
            else if (choice == "2")
            {
                Console.WriteLine("Titan`s Armor - 12 gold. Increases your armour by 5");
                Console.WriteLine("Dragon`s Tooth - 10 gold. Increases your health by 4");
                Console.WriteLine("Staff of Wizardy - 15 gold. Increases your mana by 7");
                Console.WriteLine("Dragon Slayer - 20 gold. Increases your arrack by 20");
                string itemChoice = "0";
                if (hero.Gold < 10)
                {
                    Console.WriteLine("You have no money for these items. Go Back.");
                    camp.CampLocation(hero, campChoice);

                }
                else
                {
                    do
                    {
                        Console.WriteLine("1 - Titan`s Armor. 2 - Dragon`s Tooth. 3 - Staff of Wizardy. 4 - Dragon Slayer");
                        itemChoice = Console.ReadLine();

                    }
                    while (itemChoice != "1" && itemChoice != "2" && itemChoice != "3" && itemChoice != "4");
                    if (itemChoice == "1") { 
                        if (hero.Gold >= 12)
                        {
                            Console.WriteLine("Titan`s Armor is yours");
                            hero.MaxArmor += 5;
                            hero.HrsArmour += 5;
                            hero.Gold -= 12;
                        }   else { Console.WriteLine("You don`t have enough money for this item"); camp.CampLocation(hero, campChoice); }
                    
                    }
                  
                    if (itemChoice == "2")
                    {
                        Console.WriteLine("Dragon`s Tooth is yours");
                        hero.MaxHP += 4;
                        hero.HP += 4;
                        hero.Gold -= 10;
                    }
                    if (itemChoice == "3")
                    {
                        if (hero.Gold >= 15)
                        {
                            Console.WriteLine("Staff of Wizardy is yours");
                            hero.MaxMana += 7;
                            hero.HrsManaAmount += 7;
                            hero.Gold -= 15;

                        }  else { Console.WriteLine("You don`t have enough money for this item"); camp.CampLocation(hero, campChoice); }
                    }

                    if (itemChoice == "4")
                    {
                        if (hero.Gold >= 20)
                        {
                            Console.WriteLine("Dragon Slayer is yours");
                            hero.HrsAtkPwr += 10;
                            hero.MaxAttack += 10;
                            hero.Gold -= 20;

                        }else { Console.WriteLine("You don`t have enough money for this item"); camp.CampLocation(hero, campChoice); }
                    }
                    


                }
                camp.CampLocation(hero, campChoice);


            }
           
            else if (choice == "4")
            {
                bossFightcs.BossFigth(hero, campChoice, boss);

            }
            else if (choice == "5") {
                battle.Run(hero, campChoice);
            
            }
            
        } 


} }



