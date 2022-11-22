using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Enemies
    {
        static Random random = new Random();
        //Encounters
        public static void HPPotion()
        {
            int added = Program.currentGame.health + 10;
            if (added > 100)
            {
                added = 100;
            }
            Console.WriteLine("You see a crimson liquid suspended in a glass jar. You pop off the cork and drink");
            Console.WriteLine("Your current health is " + Program.currentGame.health + "HP and after drinking the potion, it is at " + added + "HP. You now feel rejuvinated");
            Program.currentGame.health = added;
            Console.ReadKey();
            Console.Clear();
        }
        public static void MPPotion()
        {
            int added = Program.currentGame.magic + 20;
            if (added > 200)
            {
                added = 200;
            }
            Console.WriteLine("You see a teal liquid suspended in a glass jar. You pop off the cork and drink");
            Console.WriteLine("Your current magic is " + Program.currentGame.magic + "MP and after drinking the potion, it is at " + added + "MP. You now feel envigorated");
            Program.currentGame.magic = added;
            Console.ReadKey();
            Console.Clear();
        }
        public static void ThreeGoblinEncounter()
        {
            string attack = "The goblin lunges at you with all of it's weight";
            Console.WriteLine("A groupd of 3 gobins are seen roasting somehting over a small campfire. It seems to have been some rats that were fluttering around, once they see you, they spring up exposing their sharpened claws");
            Console.ReadKey();
            Combat(3, "Goblin", 2, 3, attack);
        }
        public static void TwoGoblinEncounter()
        {
            string attack = "The goblin lunges at you with all of it's weight";
            Console.WriteLine("A pair of gobins springs out from the shadows, both brandishing a set of gnarled yellowing teeth");
            Console.ReadKey();
            Combat(2, "Goblin", 2, 3, attack);
        }
        public static void OrcEncounter()
        {
            string attack = "The orc brings down a heavy cleaver, leaving you with a slash";

            Console.WriteLine("A large brute makes eye contact with you from the corner and sprints over to you with suprising speed");
            Console.ReadKey();
            Combat(1, "Orc", 3, 5, attack);
        }
        public static void TwoOrcEncounter()
        {
            string attack = "The orc brings down a heavy cleaver, leaving you with a slash";
            Console.WriteLine("A set of orcs seem puzzled by your sudden appearance and imediatly start swinging large blades");
            Console.ReadKey();
            Combat(2, "Orc", 3, 5, attack);
        }
        public static void BansheeEncounter()
        {
            string attack = "The banshee opens her mouth and releases a concosive scream from her mouth";

            Console.WriteLine("A spectral like shape can be seen from the opposite side of the room. The creature seems to resemble a somber young woman. As you approach the being, she quickly springs up and turns towards you. Her face is covered in tears.");
            Console.ReadKey();
            Combat(1, "Banshee", 5, 8, attack);
        }
        public static void TwoBansheeEncounter()
        {
            string attack = "The banshee opens her mouth and releases a concosive scream from her mouth";
            Console.WriteLine("Two ghostly white woman seem to be huddled in the cornor crying. As you arroach, they leap back and turn their faces towards you, preparing to scream.");
            Console.ReadKey();
            Combat(2, "Banshee", 5, 8, attack);
        }


        //Encounter tools
        public static void Combat(int count, string name, int damage, int health, string attackDescription)
        {
            int baseHealth = health;
            string number = "";
            int startingCount = count;
            bool done = false;

            count -= 1;
            while ((health > 0 || count > 0) && Program.currentGame.health > 0)
            {
                Console.Clear();
                if(health <= 0)
                {
                    health = baseHealth;
                    count -= 1;
                }

                //There are 2 enemies
                if (startingCount == 2)
                {
                    if (count == 1 && done == false)
                    {
                        number = " number 1";
                        damage *= 2;
                        done = true;
                    }
                    else if(count == 0 && done == true)
                    {
                        number = " number 2";
                        damage /= 2;
                        done = false;
                    }
                }

                //There are 3 enemies
                else if (startingCount == 3)
                {
                    if (count == 2 && done == false)
                    {
                        number = " number 1";
                        damage *= 3;
                        done = true;
                    }
                    else if (count == 1 && done == true)
                    {
                        number = " number 2";
                        damage /= 3;
                        damage *= 2;
                        done = false;
                    }
                    else if (count == 0 && done == false)
                    {
                        number = " number 3";
                        damage /= 2;
                        done = true;
                    }
                }
                Console.WriteLine(name + number);
                Console.WriteLine(health + " Health left");
                Console.WriteLine("");
                Console.WriteLine("Enter the first letter or type one of the actions you would like to perform ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|  (F)ireball   (H)eal  |");
                Console.WriteLine("|          (R)un        |");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Heath: " + Program.currentGame.health + "     Magic: " + Program.currentGame.magic);
                string input = Console.ReadLine();

                if (input.ToLower() == "f" || input.ToLower() == "fireball")
                {
                    //Fireball attack
                    if (Program.currentGame.magic >= 3)
                    {
                        Console.WriteLine("A glowing orb of fire shoots out of the end of your wizard staff and flies towards the enemy.");
                        Program.currentGame.magic -= 3;
                        Console.WriteLine("This spell consumes 3 of your magic points (MP) bringing you down to " + Program.currentGame.magic);
                        Console.WriteLine("");
                        Console.WriteLine("The " + name + " retaliates");
                        Console.WriteLine(attackDescription);
                        Console.WriteLine("You lose " + damage + " health and deal 5 damage back");
                        health -= 5;
                        Program.currentGame.health -= damage;
                        Console.WriteLine("You are now down to " + Program.currentGame.health + "HP");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough magic left to cast Fireball, please choose a different option");
                        Console.ReadKey();
                    }
                }

                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal spell
                    if (Program.currentGame.magic >= 5)
                    {
                        Console.WriteLine("You take a moment of rest as you cast a healing spell upon yourself. You immediatly feel much better");
                        Program.currentGame.magic -= 5;
                        Program.currentGame.health += 3;
                        //Max health 100, cannot go over
                        if(Program.currentGame.health > 100)
                        {
                            Program.currentGame.health = 100;
                        }
                        Console.WriteLine("You are now up to " + Program.currentGame.health + "HP and down to " + Program.currentGame.magic + "MP");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough magic left to cast Heal, please choose a different option");
                        Console.ReadKey();
                    }
                }

                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run away
                    //Full health run chance %100
                    if(Program.currentGame.health == 100)
                    {
                        Console.WriteLine("You feel the overwhelming sensation to runaway, so you book it out as fast as possible, back into the previous room.");
                        Console.ReadKey();
                        break;
                    }
                    //More than half health run chance %80
                    else if(Program.currentGame.health >= 50)
                    {
                        int eightOutOfTen = random.Next(1, 11);
                        if (eightOutOfTen == 1)
                        {
                            Console.WriteLine("As you turn to run away, the "+ name + "was fast to prevent your escape and attacks");
                            Program.currentGame.health -= damage;
                            Console.WriteLine("You are now down to " + Program.currentGame.health + "HP");
                        }
                        else if (eightOutOfTen == 2)
                        {
                            Console.WriteLine("As you turn to escape, you trip over your robes and fell to the ground, luckily in doing so, you avoid the attack from the " + name);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You feel the overwhelming sensation to runaway, so you book it out as fast as possible, back into the previous room.");
                            Console.ReadKey();
                            break;
                        }
                    }
                    //Less than half health run chance %50
                    else
                    {
                        int fiftyFifty = random.Next(1, 3);
                        if(fiftyFifty == 1)
                        {
                            Console.WriteLine("You feel the overwhelming sensation to runaway, so you book it out as fast as possible, back into the previous room.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("As you turn to run away, the " + name + " was fast to prevent your escape and attacks");
                            Program.currentGame.health -= damage;
                            Console.WriteLine("You are now down to " + Program.currentGame.health + "HP");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid input, please read the directions above and try again");
                    Console.ReadKey();
                }
            }
            if (health <= 0)
            {
                if (startingCount == 1)
                {
                    Console.WriteLine("You leave the " + name + " behind, still smoking from the fire");
                }
                else
                {
                    Console.WriteLine("You leave the " + name + "s behind, still smoking from the fire");
                }
            }
            if(Program.currentGame.health <= 0)
            {
                Console.WriteLine("You cannot continue your adventure because you are dead.");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
