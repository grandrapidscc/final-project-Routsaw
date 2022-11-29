using CIS129FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextToAsciiArt;

class Program
{
    public static Wizart currentGame = new Wizart();
    public static List<string> grid = new List<string>(DungeonGrid.setGrid());

    static void Main(string[] args)
    {
        bool newGame = true;
        int lostGames = 0;
        int wonGames = 0;
        while (newGame == true)
        {
            Start();
            bool exit = false;
            bool killed;
            int encounter = -1;

            while (exit == false && currentGame.health > 0)
            {
                Console.WriteLine(Movement.currentRoom());
                Console.WriteLine("");
                Console.WriteLine("Wizart: " + currentGame.health + "/100HP and " + currentGame.magic + "/200MP");
                Console.WriteLine("");
                Console.WriteLine("Please tell me which direction you would like to go or action you would like to take");
                Console.WriteLine("");
                Console.WriteLine("(F)ireball the empty room or (H)ealing spell or travel in one of the following directions");
                Console.WriteLine("--------------");
                Console.WriteLine("      N       ");
                Console.WriteLine("      |       ");
                Console.WriteLine(" W ---+--- E  ");
                Console.WriteLine("      |       ");
                Console.WriteLine("      S       ");
                Console.WriteLine("--------------");
                string input = Console.ReadLine();
                Console.Clear();
                if (input.ToLower() == "n" || input.ToLower() == "north")
                {
                    Movement.MoveUp();
                }
                else if (input.ToLower() == "s" || input.ToLower() == "south")
                {
                    Movement.MoveDown();
                }
                else if (input.ToLower() == "w" || input.ToLower() == "west")
                {
                    Movement.MoveLeft();
                }
                else if (input.ToLower() == "e" || input.ToLower() == "east")
                {
                    Movement.MoveRight();
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    var setting1 = new ArtSetting
                    {
                        ConsoleSpeed = 250,
                        Text = "+"
                    };
                    IArtWriter writer = new ArtWriter();
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
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else if (input.ToLower() == "f" || input.ToLower() == "fireball")
                {
                    var settings = new ArtSetting
                    {
                        ConsoleSpeed = 250
                    };
                    IArtWriter writer = new ArtWriter();
                    writer.WriteConsole("FIREBALL", settings);
                    Console.WriteLine("");
                    Console.WriteLine("A glowing orb of fire shoots out of the end of your wizard staff and flies through the empty room.");
                    Program.currentGame.magic -= 3;
                    Console.WriteLine("This spell consumes 3 of your magic points (MP) bringing you down to " + Program.currentGame.magic);
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("invalid input, please read the directions above and try again");
                    Console.ReadKey();
                }
                encounter = Movement.encounterNumber();
                if (encounter == 0)
                {
                    Console.WriteLine("There seems to be no other presence in this room");
                    Console.WriteLine("");
                }
                else if (encounter == 1)
                {
                    killed = Enemies.OrcEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 2)
                {
                    killed = Enemies.OrcEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 3)
                {
                    killed = Enemies.TwoOrcEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 4)
                {
                    killed = Enemies.TwoOrcEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 5)
                {
                    killed = Enemies.TwoGoblinEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 6)
                {
                    killed = Enemies.TwoGoblinEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 7)
                {
                    killed = Enemies.TwoGoblinEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 8)
                {
                    killed = Enemies.ThreeGoblinEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 9)
                {
                    killed = Enemies.BansheeEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 10)
                {
                    killed = Enemies.BansheeEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 11)
                {
                    killed = Enemies.BansheeEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 12)
                {
                    killed = Enemies.BansheeEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 13)
                {
                    killed = Enemies.TwoBansheeEncounter();
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 14)
                {
                    Enemies.HPPotion();
                    Movement.setRoom(encounter, true);
                }
                else if (encounter == 15)
                {
                    Enemies.HPPotion();
                    Movement.setRoom(encounter, true);
                }
                else if (encounter == 16)
                {
                    Enemies.MPPotion();
                    Movement.setRoom(encounter, true);
                }
                else if (encounter == 17)
                {
                    killed = Enemies.ThreeGoblinEncounter();
                    if(killed == true)
                    {
                        Enemies.HPPotion();
                    }
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 18)
                {
                    killed = Enemies.TwoBansheeEncounter();
                    if (killed == true)
                    {
                        Enemies.HPPotion();
                    }
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 19)
                {
                    killed = Enemies.OrcEncounter();
                    if (killed == true)
                    {
                        Enemies.HPPotion();
                    }
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 20)
                {
                    killed = Enemies.OrcEncounter();
                    if (killed == true)
                    {
                        Enemies.MPPotion();
                    }
                    Movement.setRoom(encounter, killed);
                }
                else if (encounter == 25)
                {
                    Console.WriteLine("You still smell the scent of burning flesh as you return to this familiar room");
                    Console.WriteLine("");
                }
                else if (encounter == 26)
                {
                    Console.WriteLine("The glass bottle that you had thrown to the ground still lies in the middle of the room");
                    Console.WriteLine("");
                }
                else if (encounter == 27)
                {
                    Console.WriteLine("You still smell the scent of burning flesh as you return to this familiar room");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("There has been an error!");
                    Console.WriteLine("");
                }
                exit = Movement.checkIfExit();
            }

            if (currentGame.health <= 0)
            {
                lostGames += 1;
                int l = lostGames;
                while (l > 0)
                {
                    Console.WriteLine("                     _____  _____                    ");
                    Console.WriteLine("                    <     `/     |                   ");
                    Console.WriteLine("                     >          (                    ");
                    Console.WriteLine("                    |   _     _  |                   ");
                    Console.WriteLine("                    |  |_) | |_) |                   ");
                    Console.WriteLine("                    |  | \\ | |   |                   ");
                    Console.WriteLine("                    |            |                   ");
                    Console.WriteLine("     ______.______%_|            |__________  _____  ");
                    Console.WriteLine("   _/                                       \\|     | ");
                    Console.WriteLine("  |                  W I Z A R T                   < ");
                    Console.WriteLine("  |_____.-._________              ____/|___________| ");
                    Console.WriteLine("                    | * fi/ll/in |                   ");
                    Console.WriteLine("                    | + 12/08/22 |                   ");
                    Console.WriteLine("                    |            |                   ");
                    Console.WriteLine("                    |            |                   ");
                    Console.WriteLine("                    |   _        <                   ");
                    Console.WriteLine("                    |__/         |                   ");
                    Console.WriteLine("                     / `--.      |                   ");
                    Console.WriteLine("                   %|            |%                  ");
                    Console.WriteLine("               |/.%%|          -< @%%%               ");
                    Console.WriteLine("               `\\%`@|     v      |@@%@%%    - mfj    ");
                    Console.WriteLine("             .%%%@@@|%    |    % @@@%%@%%%%          ");
                    Console.WriteLine("       _.%%%%%%@@@@@@%%_/%\\_%@@%%@@@@@@@%%%%%%       ");
                    l -= 1;
                }
            }
            else
            {
                Console.Clear();
                wonGames += 1;
                Console.WriteLine("Congrats! You made it out!");
                Console.WriteLine("                  .'* *.'             ");
                Console.WriteLine("               __/_*_*(_              ");
                Console.WriteLine("              / _______ \\             ");
                Console.WriteLine("             _\\_)/___\\(_/_            ");
                Console.WriteLine("            / _((\\- -/))_ \\           ");
                Console.WriteLine("            \\ \\())(-)(()/ /           ");
                Console.WriteLine("             ' \\(((()))/ '            ");
                Console.WriteLine("            / ' \\)).))/ ' \\           ");
                Console.WriteLine("           / _ \\ - | - /_  \\          ");
                Console.WriteLine("          (   ( .;''';. .'  )         ");
                Console.WriteLine("          _\\\"__ /    )\\ __\"/_         ");
                Console.WriteLine("            \\/  \\   ' /  \\/           ");
                Console.WriteLine("             .'  '...' ' )            ");
                Console.WriteLine("              / /  |  \\ \\             ");
                Console.WriteLine("             / .   .   . \\            ");
                Console.WriteLine("            /   .     .   \\           ");
                Console.WriteLine("           /   /   |   \\   \\          ");
                Console.WriteLine("         .'   /    b    '.  '.        ");
                Console.WriteLine("     _.-'    /     Bb     '-. '-._    ");
                Console.WriteLine(" _.-'       |      BBb       '-.  '-. ");
                Console.WriteLine("(________mrf\\____.dBBBb.________)____)");
            }
            Console.WriteLine("");
            if(wonGames != 1 && lostGames != 1)
            {
                Console.WriteLine("You have a total of " + wonGames + " winning games and " + lostGames + " lost games!");
            }
            else if(wonGames == 1 && lostGames == 1)
            {
                Console.WriteLine("You have a total of " + wonGames + " winning game and " + lostGames + " lost game!");
            }
            else if(wonGames != 1 && lostGames == 1)
            {
                Console.WriteLine("You have a total of " + wonGames + " winning games and " + lostGames + " lost game!");
            }
            else
            {
                Console.WriteLine("You have a total of " + wonGames + " winning game and " + lostGames + " lost games!");
            }
            Console.WriteLine("");
            Console.WriteLine("Would you like to play again? (Y)es or (N)o");
            string input1 = "";
            while (input1 != "Wizart")
            {
                input1 = Console.ReadLine();
                if (input1.ToLower() == "n" || input1.ToLower() == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Are you positive you do not want to continue playing? (Y)es or (N)o\"");
                    input1 = Console.ReadLine();
                    if (input1.ToLower() == "n" || input1.ToLower() == "no")
                    {
                        Console.WriteLine("Good choice! Let's keep going!");
                        Console.ReadKey();
                        newGame = true;
                        input1 = "Wizart";
                        Console.Clear();
                    }
                    else if (input1.ToLower() == "y" || input1.ToLower() == "yes")
                    {
                        Console.WriteLine("Okay, okay...are you absolutly 100% positive you do not not want to continue playing? (Y)es or (N)o");
                        input1 = Console.ReadLine();
                        if (input1.ToLower() == "y" || input1.ToLower() == "yes")
                        {
                            Console.WriteLine("Ha, fell for the double negative! That means we can keep playing...TITLE SCREEN!!");
                            Console.ReadKey();
                            newGame = true;
                            input1 = "Wizart";
                            Console.Clear();
                        }
                        else if (input1.ToLower() == "n" || input1.ToLower() == "no")
                        {
                            Console.WriteLine("Well I guess you went to grammar class didn't you....well okay fine leave! I didn't want to play with you anyway...( o.o,)");
                            Console.WriteLine("");
                            Console.WriteLine("I'm not crying, your crying ( o.o, )");
                            Console.WriteLine("");
                            var settings = new ArtSetting
                            {
                                ConsoleSpeed = 3000,
                                Text = "0"
                            };
                            IArtWriter writer = new ArtWriter();
                            writer.WriteConsole("GOODBYE", settings);
                            Console.WriteLine("");
                            Console.WriteLine("Maybe play one more game to stop him from crying, hey? What do you say? (Y)es or (N)o");
                            input1 = Console.ReadLine();
                            if (input1.ToLower() == "n" || input1.ToLower() == "no")
                            {
                                Console.WriteLine("You really are a monster..........");
                                newGame = false;
                                input1 = "Wizart";
                            }
                            else if (input1.ToLower() == "y" || input1.ToLower() == "yes")
                            {
                                Console.WriteLine("Th...ank yo..oo..ou...LET'S PLAY!");
                                Console.ReadKey();
                                newGame = true;
                                input1 = "Wizart";
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please enter either Y for yes or N for no");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Invalid input, please enter either Y for yes or N for no");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter either Y for yes or N for no");
                    }
                }
                else if (input1.ToLower() == "y" || input1.ToLower() == "yes")
                {
                    newGame = true;
                    input1 = "Wizart";
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter either Y for yes or N for no");
                }
            }
        }
    }

    static void Start()
    {
        IArtWriter writer = new ArtWriter();
        currentGame.health = 50;
        currentGame.magic = 200;
        var settings = new ArtSetting
        {
            ConsoleSpeed = 300,
            Text = "#"
        };
        writer.WriteConsole("Wizert 5", settings);
        Console.WriteLine("");
        writer.WriteConsole("Rabid Hunt", settings);
        Console.WriteLine("");
        Console.WriteLine("Welcome Wizart, great and powerful wizard. Prepare yourself for the ultimate test!");
        Console.WriteLine("");


        Console.WriteLine("Press any key to begin your dungeoneering adventure!");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Your eyes feel heavy and your muscles are fatigued. \"Where am I?\", you think to yourself as you pick yourself up off the cold and stony ground. As you pick yourself up, you realize that you are bleeding pretty badly from a wound in your leg.");
        Console.WriteLine("");
        Console.WriteLine("You decide to venture forth to try and find the exit to this mysterious dungeon");
        Movement.randomizeStartAndEnd();
        Movement.resetRooms();
        Console.ReadKey();
        Console.Clear();
    }



}