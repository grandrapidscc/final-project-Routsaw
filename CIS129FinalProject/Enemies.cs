using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextToAsciiArt;

namespace CIS129FinalProject
{
    internal class Enemies
    {
        static Random random = new Random();

        public static bool isDead()
        {
            if (Program.currentGame.health <= 0)
            {
                return true;
            }
            else { return false; }
        }
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
        public static bool ThreeGoblinEncounter()
        {
            string attack = "The goblin lunges at you with all of it's weight";
            Console.WriteLine("A groupd of 3 gobins are seen roasting somehting over a small campfire. It seems to have been some rats that were fluttering around, once they see you, they spring up exposing their sharpened claws");
            Console.ReadKey();
            bool killed = Combat(3, "Goblin", 2, 3, attack);
            return killed;
        }
        public static bool TwoGoblinEncounter()
        {
            string attack = "The goblin lunges at you with all of it's weight";
            Console.WriteLine("A pair of gobins springs out from the shadows, both brandishing a set of gnarled yellowing teeth");
            Console.ReadKey();
            bool killed = Combat(2, "Goblin", 2, 3, attack);
            return killed;
        }
        public static bool OrcEncounter()
        {
            string attack = "The orc brings down a heavy cleaver, leaving you with a slash";

            Console.WriteLine("A large brute makes eye contact with you from the corner and sprints over to you with suprising speed");
            Console.ReadKey();
            bool killed = Combat(1, "Orc", 3, 5, attack);
            return killed;
        }
        public static bool TwoOrcEncounter()
        {
            string attack = "The orc brings down a heavy cleaver, leaving you with a slash";
            Console.WriteLine("A set of orcs seem puzzled by your sudden appearance and imediatly start swinging large blades");
            Console.ReadKey();
            bool killed = Combat(2, "Orc", 3, 5, attack);
            return killed;
        }
        public static bool BansheeEncounter()
        {
            string attack = "The banshee opens her mouth and releases a concosive scream from her mouth";

            Console.WriteLine("A spectral like shape can be seen from the opposite side of the room. The creature seems to resemble a somber young woman. As you approach the being, she quickly springs up and turns towards you. Her face is covered in tears.");
            Console.ReadKey();
            bool killed = Combat(1, "Banshee", 5, 8, attack);
            return killed;
        }
        public static bool TwoBansheeEncounter()
        {
            string attack = "The banshee opens her mouth and releases a concosive scream from her mouth";
            Console.WriteLine("Two ghostly white woman seem to be huddled in the cornor crying. As you arroach, they leap back and turn their faces towards you, preparing to scream.");
            Console.ReadKey();
            bool killed = Combat(2, "Banshee", 5, 8, attack);
            return killed;
        }


        //Encounter tools
        public static bool Combat(int count, string name, int damage, int health, string attackDescription)
        {
            IArtWriter writer = new ArtWriter();
            bool success = false;
            bool dead = false;
            bool creatureDead = false;
            int baseHealth = health;
            string number = "";
            int startingCount = count;
            bool done = false;

            count -= 1;
            while ((health > 0 || count > 0) && Program.currentGame.health > 0 && success == false)
            {
                Console.Clear();
                if (health <= 0)
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
                    else if (count == 0 && done == true)
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
                if(name == "Goblin")
                {
                    if (count == 0) {
                        Console.WriteLine("                              .\\            ");
                        Console.WriteLine("                        .\\   / _\\   .\\      ");
                        Console.WriteLine("                       / _ \\   ||   / _\\");
                        Console.WriteLine("                        ||    ||    ||  ");
                        Console.WriteLine("                 ; ,     \\`.__||__.'/   ");
                        Console.WriteLine("         |\\     /( ;\\_.;  `./|  __.'    ");
                        Console.WriteLine("         ' `.  _|_\\/_;-'_ .' '||        ");
                        Console.WriteLine("          \\ _ /`       `.-\\_ / ||       ");
                        Console.WriteLine("      , _ _`; ,--.   ,--. ;'_ _|,       ");
                        Console.WriteLine("      '`''\\| /  ,-\\ | _,-\\ |/''`'       ");
                        Console.WriteLine("       \\ .-- \\__\\_/ /` )_/ --. /        ");
                        Console.WriteLine("       /    .         -'  .    \\        ");
                        Console.WriteLine("      |     /             \\    |        ");
                        Console.WriteLine("   .   .  -' `-..____...-' `-  .        ");
                        Console.WriteLine(".'`'.__ `._      `-..-''    _.'|        ");
                        Console.WriteLine(" \\ .--.`.  `-..__    _,..-'   L|        ");
                        Console.WriteLine("  '    \\ \\      _,| |,_      /_7)       "); 
                        Console.WriteLine("        \\ \\    /       \\ _.-'/||        ");
                        Console.WriteLine("         \\ \\  /.'|   |`.__.'` ||        ");
                        Console.WriteLine("          \\ `//_/     \\       ||        ");
                        Console.WriteLine("           `/ \\|       |      ||        ");
                        Console.WriteLine("            `\"`'.  _  .'      ||        ");
                        Console.WriteLine("                 \\ | /        ||        ");
                        Console.WriteLine("                  | '|        'J        ");
                        Console.WriteLine("               .-.|||.-.                ");
                        Console.WriteLine("              '----\"----'               ");
                    }
                    else
                    {
                        Console.WriteLine("                             .\\                                           .\\            ");
                        Console.WriteLine("                        .\\   / _\\   .\\                             .\\   / _\\   .\\      ");
                        Console.WriteLine("                      / _ \\   ||   / _\\                          / _ \\   ||   / _\\");
                        Console.WriteLine("                        ||    ||    ||                             ||    ||    ||  ");
                        Console.WriteLine("                 ; ,     \\`.__||__.'/                       ; ,     \\`.__||__.'/   ");
                        Console.WriteLine("         |\\     /( ;\\_.;  `./|  __.'                |\\     /( ;\\_.;  `./|  __.'    ");
                        Console.WriteLine("         ' `.  _|_\\/_;-'_ .' '||                    ' `.  _|_\\/_;-'_ .' '||        ");
                        Console.WriteLine("          \\ _ /`       `.-\\_ / ||                    \\ _ /`       `.-\\_ / ||       ");
                        Console.WriteLine("      , _ _`; ,--.   ,--. ;'_ _|,                , _ _`; ,--.   ,--. ;'_ _|,       ");
                        Console.WriteLine("      '`''\\| /  ,-\\ | _,-\\ |/''`'                '`''\\| /  ,-\\ | _,-\\ |/''`'       ");
                        Console.WriteLine("       \\ .-- \\__\\_/ /` )_/ --. /                  \\ .-- \\__\\_/ /` )_/ --. /        ");
                        Console.WriteLine("       /    .         -'  .    \\                  /    .         -'  .    \\        ");
                        Console.WriteLine("      |     /             \\    |                 |     /             \\    |        ");
                        Console.WriteLine("   .   .  -' `-..____...-' `-  .              .   .  -' `-..____...-' `-  .        ");
                        Console.WriteLine(".'`'.__ `._      `-..-''    _.'|           .'`'.__ `._      `-..-''    _.'|        ");
                        Console.WriteLine(" \\ .--.`.  `-..__    _,..-'   L|            \\ .--.`.  `-..__    _,..-'   L|        ");
                        Console.WriteLine("  '    \\ \\      _,| |,_      /_7)            '    \\ \\      _,| |,_      /_7)       ");
                        Console.WriteLine("        \\ \\    /       \\ _.-'/||                   \\ \\    /       \\ _.-'/||        ");
                        Console.WriteLine("         \\ \\  /.'|   |`.__.'` ||                    \\ \\  /.'|   |`.__.'` ||        ");
                        Console.WriteLine("          \\ `//_/     \\       ||                     \\ `//_/     \\       ||        ");
                        Console.WriteLine("           `/ \\|       |      ||                      `/ \\|       |      ||        ");
                        Console.WriteLine("            `\"`'.  _  .'      ||                       `\"`'.  _  .'      ||        ");
                        Console.WriteLine("                 \\ | /        ||                            \\ | /        ||        ");
                        Console.WriteLine("                  | '|        'J                             | '|        'J        ");
                        Console.WriteLine("               .-.|||.-.                                  .-.|||.-.                ");
                        Console.WriteLine("              '----\"----'                                '----\"----'               ");
                    }
                }
                else if(name == "Orc")
                {
                    if (count == 0)
                    {
                        Console.WriteLine("          _......._            ");
                        Console.WriteLine("       .-'.'.'.'.'.'.`-.       ");
                        Console.WriteLine("     .'.'.'.'.'.'.'.'.'.`.     ");
                        Console.WriteLine("    /.'.'               '.\\    ");
                        Console.WriteLine("    |.'    _.--...--._     |   ");
                        Console.WriteLine("    \\    `._.-.....-._.'   /   ");
                        Console.WriteLine("    |     _..- .-. -.._   |    ");
                        Console.WriteLine(" .-.'   `.((@))   ((@)).' '.-. ");
                        Console.WriteLine("( ^ \\      `--.   .-'     / ^ )");
                        Console.WriteLine(" \\  /         .   .       \\  / ");
                        Console.WriteLine(" /          .'     '.  .-    \\ ");
                        Console.WriteLine("( _.\\    \\ (_`-._.-'_)    /._\\)");
                        Console.WriteLine(" `-' \\   ' .--.          / `-' ");
                        Console.WriteLine("     |  / /|_| `-._.'\\   |     ");
                        Console.WriteLine("     |   |       |_| |   /-.._ ");
                        Console.WriteLine(" _..-\\   `.--.______.'  |      ");
                        Console.WriteLine("      \\       .....     |      ");
                        Console.WriteLine("       `.  .'      `.  /       ");
                        Console.WriteLine("         \\           .'        ");
                        Console.WriteLine("          `-..___..-`          ");
                    }
                    else
                    {
                        Console.WriteLine("          _......._                         _......._            ");
                        Console.WriteLine("       .-'.'.'.'.'.'.`-.                 .-'.'.'.'.'.'.`-.       ");
                        Console.WriteLine("     .'.'.'.'.'.'.'.'.'.`.             .'.'.'.'.'.'.'.'.'.`.     ");
                        Console.WriteLine("    /.'.'               '.\\           /.'.'               '.\\    ");
                        Console.WriteLine("    |.'    _.--...--._     |          |.'    _.--...--._     |   ");
                        Console.WriteLine("    \\    `._.-.....-._.'   /          \\    `._.-.....-._.'   /   ");
                        Console.WriteLine("    |     _..- .-. -.._   |           |     _..- .-. -.._   |    ");
                        Console.WriteLine(" .-.'   `.((@))   ((@)).' '.-.     .-.'   `.((@))   ((@)).' '.-. ");
                        Console.WriteLine("( ^ \\      `--.   .-'     / ^ )   ( ^ \\      `--.   .-'     / ^ )");
                        Console.WriteLine(" \\  /         .   .       \\  /     \\  /         .   .       \\  / ");
                        Console.WriteLine(" /          .'     '.  .-    \\     /          .'     '.  .-    \\ ");
                        Console.WriteLine("( _.\\    \\ (_`-._.-'_)    /._\\)   ( _.\\    \\ (_`-._.-'_)    /._\\)");
                        Console.WriteLine(" `-' \\   ' .--.          / `-'     `-' \\   ' .--.          / `-' ");
                        Console.WriteLine("     |  / /|_| `-._.'\\   |             |  / /|_| `-._.'\\   |     ");
                        Console.WriteLine("     |   |       |_| |   /-.._         |   |       |_| |   /-.._ ");
                        Console.WriteLine(" _..-\\   `.--.______.'  |          _..-\\   `.--.______.'  |      ");
                        Console.WriteLine("      \\       .....     |               \\       .....     |      ");
                        Console.WriteLine("       `.  .'      `.  /                 `.  .'      `.  /       ");
                        Console.WriteLine("         \\           .'                    \\           .'        ");
                        Console.WriteLine("          `-..___..-`                       `-..___..-`          ");
                    }
                }
                else if(name == "Banshee")
                {
                    if (count == 0)
                    {
                        Console.WriteLine("         .--.   _,              ");
                        Console.WriteLine("          \\ /(_                 ");
                        Console.WriteLine("           |   '-._             ");
                        Console.WriteLine("           \\    ,-.)            ");
                        Console.WriteLine("   /\\_      \\((` .(             ");
                        Console.WriteLine("   \\ /       )\\  _/   _         ");
                        Console.WriteLine("    \\\\    .-'   '--. /_\\        ");
                        Console.WriteLine("     \\\\_.' ,        \\/||        ");
                        Console.WriteLine("      \\_.-';,_) _)'\\ \\||        ");
                        Console.WriteLine("           `\\   (   '._/        ");
                        Console.WriteLine("            |  . '.             ");
                        Console.WriteLine("            |      \\            ");
                        Console.WriteLine("            |  \\|   |           ");
                        Console.WriteLine("             \\  |   |           ");
                        Console.WriteLine("              '.|   |           ");
                        Console.WriteLine("                 \\  '\\__        ");
                        Console.WriteLine("                  `-._  '. _    ");
                        Console.WriteLine("                     \\`; -.` `._");
                        Console.WriteLine("                      \\ \\ `'-._\\");
                        Console.WriteLine("                       \\ |      ");
                        Console.WriteLine("                        \\ )     ");
                        Console.WriteLine("                         \\_\\    ");
                    }
                    else
                    {
                        Console.WriteLine("         .--.   _,                          .--.   _,              ");
                        Console.WriteLine("          \\ /(_                              \\ /(_                 ");
                        Console.WriteLine("           |   '-._                           |   '-._             ");
                        Console.WriteLine("           \\    ,-.)                          \\    ,-.)            ");
                        Console.WriteLine("   /\\_      \\((` .(                   /\\_      \\((` .(             ");
                        Console.WriteLine("   \\ /       )\\  _/   _               \\ /       )\\  _/   _         ");
                        Console.WriteLine("    \\\\    .-'   '--. /_\\               \\\\    .-'   '--. /_\\        ");
                        Console.WriteLine("     \\\\_.' ,        \\/||                \\\\_.' ,        \\/||        ");
                        Console.WriteLine("      \\_.-';,_) _)'\\ \\||                 \\_.-';,_) _)'\\ \\||        ");
                        Console.WriteLine("           `\\   (   '._/                      `\\   (   '._/        ");
                        Console.WriteLine("            |  . '.                            |  . '.             ");
                        Console.WriteLine("            |      \\                           |      \\            ");
                        Console.WriteLine("            |  \\|   |                          |  \\|   |           ");
                        Console.WriteLine("             \\  |   |                           \\  |   |           ");
                        Console.WriteLine("              '.|   |                            '.|   |           ");
                        Console.WriteLine("                 \\  '\\__                            \\  '\\__        ");
                        Console.WriteLine("                  `-._  '. _                         `-._  '. _    ");
                        Console.WriteLine("                     \\`; -.` `._                        \\`; -.` `._");
                        Console.WriteLine("                      \\ \\ `'-._\\                         \\ \\ `'-._\\");
                        Console.WriteLine("                       \\ |                                \\ |      ");
                        Console.WriteLine("                        \\ )                                \\ )     ");
                        Console.WriteLine("                         \\_\\                                \\_\\       ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Enter the first letter or type one of the actions you would like to perform ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|  (F)ireball   (H)eal  |");
                Console.WriteLine("|          (R)un        |");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Heath: " + Program.currentGame.health + "/100     Magic: " + Program.currentGame.magic + "/200");
                string input = Console.ReadLine();

                if (input.ToLower() == "f" || input.ToLower() == "fireball")
                {
                    //Fireball attack
                    if (Program.currentGame.magic >= 3)
                    {
                        var settings = new ArtSetting
                        {
                            ConsoleSpeed = 250
                        };
                        var setting = new ArtSetting
                        {
                            ConsoleSpeed = 1000,
                            Text = "X"
                        };
                        writer.WriteConsole("FIREBALL", settings);
                        Console.WriteLine("");
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
                        dead = isDead();
                        if (dead == true)
                        {
                            Console.Clear();
                            writer.WriteConsole("YOU HAVE DIED", setting);
                            Console.WriteLine("");
                            break;
                        }
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
                        var setting1 = new ArtSetting
                        {
                            ConsoleSpeed = 250,
                            Text = "+"
                        };
                        writer.WriteConsole("HEALING WORD", setting1);
                        Console.WriteLine("");
                        Console.WriteLine("You take a moment of rest as you cast a healing spell upon yourself. You immediatly feel much better");
                        Program.currentGame.magic -= 5;
                        Program.currentGame.health += 3;
                        //Max health 100, cannot go over
                        if (Program.currentGame.health > 100)
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
                    success = Movement.runAway(damage, name);
                    Movement.Run(success);
                    if (success == true)
                    {
                        Movement.currentRoom();
                        Console.WriteLine("");
                        writer.WriteConsole("RUN SUCCESS", null);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        writer.WriteConsole("RUN UNSUCCESSFUL", null);
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("invalid input, please read the directions above and try again");
                    Console.ReadKey();
                }
            }
            if (health <= 0 && count <= 0 && dead != true)
            {
                if (startingCount == 1)
                {
                    Console.WriteLine("You leave the " + name + " behind, still smoking from the fire");
                }
                else
                {
                    Console.WriteLine("You leave the " + name + "s behind, still smoking from the fire");
                }
                creatureDead = true;
            }
            else
            {
                creatureDead = false;
            }
            if (Program.currentGame.health <= 0)
            {
                Console.WriteLine("You cannot continue your adventure because you are dead.");
            }

            Console.ReadKey();
            Console.Clear();
            return creatureDead;
        }
    }


}