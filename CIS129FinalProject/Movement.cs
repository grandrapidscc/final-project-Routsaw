using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace CIS129FinalProject
{
    internal class Movement
    {
        static bool room1 = true;
        static bool room2 = true;
        static bool room3 = true;
        static bool room4 = true;
        static bool room5 = true;
        static bool room6 = true;
        static bool room7 = true;
        static bool room8 = true;
        static bool room9 = true;
        static bool room10 = true;
        static bool room11 = true;
        static bool room12 = true;
        static bool room13 = true;
        static bool room14 = true;
        static bool room15 = true;
        static bool room16 = true;
        static bool room17 = true;
        static bool room18 = true;
        static bool room19 = true;
        static bool room20 = true;

        static Random random = new Random();
        static string[,] Grid = new string[5, 5] {{Program.grid [0], Program.grid[1], Program.grid[2], Program.grid[3], Program.grid[4]},
                                              {Program.grid [5], Program.grid[6], Program.grid[7], Program.grid[8], Program.grid[9]},
                                              {Program.grid [10], Program.grid[11], Program.grid[12], Program.grid[13], Program.grid[14]},
                                              {Program.grid [15], Program.grid[16], Program.grid[17], Program.grid[18], Program.grid[19]},
                                              {Program.grid [20], Program.grid[21], Program.grid[22], Program.grid[23], Program.grid[24]}};

        static int currentX = 0;
        static int currentY = 0;
        static int previousX = 0;
        static int previousY = 0;
        static int exitX = 0;
        static int exitY = 0;

        public static void randomizeStartAndEnd() 
        {
            currentX = random.Next(0, 5);
            currentY = random.Next(0, 5);
            exitX = random.Next(0, 5);
            exitY = random.Next(0, 5);
        }
        public static string currentRoom()
        {
            return Grid[currentX, currentY];
        }

        public static bool checkRoom(int room)
        {
            if (room == 1)
            {
                return room1;
            }
            else if (room == 2)
            {
                return room2;
            }
            else if (room == 3)
            {
                return room3;
            }
            else if (room == 4)
            {
                return room4;
            }
            else if (room == 5)
            {
                return room5;
            }
            else if (room == 6)
            {
                return room6;
            }
            else if (room == 7)
            {
                return room7;
            }
            else if (room == 8)
            {
                return room8;
            }
            else if (room == 9)
            {
                return room9;
            }
            else if (room == 10)
            {
                return room10;
            }
            else if (room == 11)
            {
                return room11;
            }
            else if (room == 12)
            {
                return room12;
            }
            else if (room == 13)
            {
                return room13;
            }
            else if (room == 14)
            {
                return room14;
            }
            else if (room == 15)
            {
                return room15;
            }
            else if (room == 16)
            {
                return room16;
            }
            else if (room == 17)
            {
                return room17;
            }
            else if (room == 18)
            {
                return room18;
            }
            else if (room == 19)
            {
                return room19;
            }
            else if (room == 20)
            {
                return room20;
            }
            else
            {
                return true;
            }
        }

        public static void resetRooms()
        {
            room1 = true;
            room2 = true;
            room3 = true;
            room4 = true;
            room5 = true;
            room6 = true;
            room7 = true;
            room8 = true;
            room9 = true;
            room10 = true;
            room11 = true;
            room12 = true;
            room13 = true;
            room14 = true;
            room15 = true;
            room16 = true;
            room17 = true;
            room18 = true;
            room19 = true;
            room20 = true;
        }
        public static void setRoom(int room, bool dead)
        {
            if (dead == false)
            {
            }
            else if (room == 1)
            {
                room1 = false;
            }
            else if (room == 2)
            {
                room2 = false;
            }
            else if (room == 3)
            {
                room3 = false;
            }
            else if (room == 4)
            {
                room4 = false;
            }
            else if (room == 5)
            {
                room5 = false;
            }
            else if (room == 6)
            {
                room6 = false;
            }
            else if (room == 7)
            {
                room7 = false;
            }
            else if (room == 8)
            {
                room8 = false;
            }
            else if (room == 9)
            {
                room9 = false;
            }
            else if (room == 10)
            {
                room10 = false;
            }
            else if (room == 11)
            {
                room11 = false;
            }
            else if (room == 12)
            {
                room12 = false;
            }
            else if (room == 13)
            {
                room13 = false;
            }
            else if (room == 14)
            {
                room14 = false;
            }
            else if (room == 15)
            {
                room15 = false;
            }
            else if (room == 16)
            {
                room16 = false;
            }
            else if (room == 17)
            {
                room17 = false;
            }
            else if (room == 18)
            {
                room18 = false;
            }
            else if (room == 19)
            {
                room19 = false;
            }
            else if (room == 20)
            {
                room20 = false;
            }
        }

        public static int encounterNumber()
        {
            //0 means no encounter (5 spots)
            if ((currentX == 0 && currentY == 0) || (currentX == 0 && currentY == 4) || (currentX == 0 && currentY == 2) || (currentX == 2 && currentY == 4) || (currentX == 4 && currentY == 0))
            {
                return 0;
            }
            //1 orc (room1 and room2)
            else if ((currentX == 1 && currentY == 0) || (currentX == 0 && currentY == 1))
            {
                if (currentX == 1)
                {
                    bool check = checkRoom(1);
                    if (check == true)
                    {
                        return 1;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else
                {
                    bool check = checkRoom(2);
                    if (check == true)
                    {
                        return 2;
                    }
                    else
                    {
                        return 25;
                    }
                }
            }
            //2 orcs (room3 and room4)
            else if ((currentX == 2 && currentY == 2) || (currentX == 3 && currentY == 3))
            {
                if (currentX == 2)
                {
                    bool check = checkRoom(3);
                    if (check == true)
                    {
                        return 3;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else
                {
                    bool check = checkRoom(4);
                    if (check == true)
                    {
                        return 4;
                    }
                    else
                    {
                        return 25;
                    }
                }
            }
            //2 goblins (room5 and room6 and room7)
            else if ((currentX == 1 && currentY == 1) || (currentX == 3 && currentY == 2) || (currentX == 4 && currentY == 3))
            {
                if (currentX == 1)
                {
                    bool check = checkRoom(5);
                    if (check == true)
                    {
                        return 5;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else if (currentX == 3)
                {
                    bool check = checkRoom(6);
                    if (check == true)
                    {
                        return 6;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else
                {
                    bool check = checkRoom(7);
                    if (check == true)
                    {
                        return 7;
                    }
                    else
                    {
                        return 25;
                    }
                }
            }
            //3 goblins (room8)
            else if (currentX == 2 && currentY == 0)
            {
                bool check = checkRoom(8);
                if (check == true)
                {
                    return 8;
                }
                else
                {
                    return 25;
                }
            }
            //1 banshee (room9 and room10 and room11 and room12)
            else if ((currentX == 1 && currentY == 4) || (currentX == 1 && currentY == 2) || (currentX == 4 && currentY == 4) || (currentX == 4 && currentY == 2))
            {
                if (currentX == 1 && currentY == 4)
                {
                    bool check = checkRoom(9);
                    if (check == true)
                    {
                        return 9;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else if (currentX == 1)
                {
                    bool check = checkRoom(10);
                    if (check == true)
                    {
                        return 10;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else if (currentX == 4 && currentY == 4)
                {
                    bool check = checkRoom(11);
                    if (check == true)
                    {
                        return 11;
                    }
                    else
                    {
                        return 25;
                    }
                }
                else
                {
                    bool check = checkRoom(12);
                    if (check == true)
                    {
                        return 12;
                    }
                    else
                    {
                        return 25;
                    }
                }
            }
            //2 banshee (room13)
            else if (currentX == 2 && currentY == 1)
            {
                bool check = checkRoom(13);
                if (check == true)
                {
                    return 13;
                }
                else
                {
                    return 25;
                }
            }
            //HP potion (room14 and room15)
            else if ((currentX == 3 && currentY == 4) || (currentX == 0 && currentY == 3))
            {
                if (currentX == 3)
                {
                    bool check = checkRoom(14);
                    if (check == true)
                    {
                        return 14;
                    }
                    else
                    {
                        return 26;
                    }
                }
                else
                {
                    bool check = checkRoom(15);
                    if (check == true)
                    {
                        return 15;
                    }
                    else
                    {
                        return 26;
                    }
                }
            }
            //MP potion (room16)
            else if (currentX == 1 && currentY == 3)
            {
                bool check = checkRoom(16);
                if (check == true)
                {
                    return 16;
                }
                else
                {
                    return 26;
                }
            }
            //3 goblins with HP (room17)
            else if (currentX == 2 && currentY == 3)
            {
                bool check = checkRoom(17);
                if (check == true)
                {
                    return 17;
                }
                else
                {
                    return 27;
                }
            }
            //2 banshee with HP (room18)
            else if (currentX == 3 && currentY == 1)
            {
                bool check = checkRoom(18);
                if (check == true)
                {
                    return 18;
                }
                else
                {
                    return 27;
                }
            }
            //orc with MP (room19)
            else if (currentX == 3 && currentY == 0)
            {
                bool check = checkRoom(19);
                if (check == true)
                {
                    return 19;
                }
                else
                {
                    return 27;
                }
            }
            // orc with HP (room20)
            else if (currentX == 4 && currentY == 1)
            {
                bool check = checkRoom(20);
                if (check == true)
                {
                    return 20;
                }
                else
                {
                    return 27;
                }
            }
            else
            {
                return -1;
            }
        }

        public static bool checkIfExit()
        {
            if (currentX == exitX && currentY == exitY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool runAway(int damage, string name)
        {
            //Run away
            //Full health run chance %100
            if (Program.currentGame.health == 100)
            {
                Console.WriteLine("You feel the overwhelming sensation to runaway, so you book it out as fast as possible, back into the previous room.");
                Console.ReadKey();
                return true;
            }
            //More than half health run chance %80
            else if (Program.currentGame.health >= 50)
            {
                int eightOutOfTen = random.Next(1, 11);
                if (eightOutOfTen == 1)
                {
                    Console.WriteLine("As you turn to run away, the " + name + " was fast to prevent your escape and attacks");
                    Program.currentGame.health -= damage;
                    Console.WriteLine("You are now down to " + Program.currentGame.health + "HP");
                    return false;
                }
                else if (eightOutOfTen == 2)
                {
                    Console.WriteLine("As you turn to escape, you trip over your robes and fell to the ground, luckily in doing so, you avoid the attack from the " + name + ". However, you did not manage to escape.");
                    Console.ReadKey();
                    return false;
                }
                else
                {
                    Console.WriteLine("You feel the overwhelming sensation to runaway, so you book it out as fast as possible, back into the previous room.");
                    Console.ReadKey();
                    return true;
                }
            }
            //Less than half health run chance %50
            else
            {
                int fiftyFifty = random.Next(1, 3);
                if (fiftyFifty == 1)
                {
                    Console.WriteLine("You feel the overwhelming sensation to runaway, so you book it out as fast as possible, back into the previous room.");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.WriteLine("As you turn to run away, the " + name + " was fast to prevent your escape and attacks");
                    Program.currentGame.health -= damage;
                    Console.WriteLine("You are now down to " + Program.currentGame.health + "HP");
                    Console.ReadKey();
                    return false;
                }
            }
        }

        public static void MoveRight()
        {

            if (currentX == 4)
            {
                Console.WriteLine("There are no doors or crevices to the east that you can squeeze your body into.");
            }
            else
            {
                previousX = currentX;
                previousY = currentY;
                currentX += 1;
            }
        }
        public static void MoveUp()
        {
            if (currentY == 0)
            {
                Console.WriteLine("There are no doors or crevices to the north that you can squeeze your body into.");
            }
            else
            {
                previousX = currentX;
                previousY = currentY;
                currentY -= 1;
            }
        }
        public static void MoveDown()
        {
            if (currentY == 4)
            {
                Console.WriteLine("There are no doors or crevices to the south that you can squeeze your body into.");
            }
            else
            {
                previousX = currentX;
                previousY = currentY;
                currentY += 1;
            }
        }
        public static void MoveLeft()
        {
            if (currentX == 0)
            {
                Console.WriteLine("There are no doors or crevices to the west that you can squeeze your body into.");
            }
            else
            {
                previousX = currentX;
                previousY = currentY;
                currentX -= 1;
            }
        }
        public static void Run(bool success)
        {
            if(success == true)
            {
                currentY = previousY;
                currentX = previousX;
            }
        }
    }
}