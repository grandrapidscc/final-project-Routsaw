using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class DungeonGrid
    {
        static Random random = new Random();

        public static string Rooms(int roomNumber)
        {
            string roomOne = "A narrow trickle of a crimson liquid flows across the wall to the west. The dank room is covered in puddles of the strange liquid, cobwebs and moss.";
            string roomTwo = "You enter the room and get hit with a putrid smell of rotting flesh. The room is  covered in broken stone, large bones and small bones. In the corner of the room you hear a disgrunteled voice mumbling to itself.";
            string roomThree = "There are numerous scorch marks and signs of fire along the floor of this room. Sketches of an elf colored in black adorn the walls. All the sketches seem to be of the same elf, as they all have a scar upon the left cheek. The room smells metallic and a loud coughing noise can be heard.";
            string roomFour = "The ceiling is a slanted with arm-thick tendrils of viscous brown goo that hangs down to the floor in half a dozen places. It seems to be covering a small open chest.";
            string roomFive = "Small wildflowers have been crudely painted all around the base of the walls and a ratty old cloak hangs from a hook on one wall. The air in the room is misty and cold, it room smells of Urine and a loud chiming noise can be heard in the distance.";
            string roomSix = "The entire floor is covered with a smooth sheet of ice about two inches thick. Fist sized holes cover one corner and parts of the two adjoining walls. A loud chiming noise can be heard.";
            string roomSeven = "The ceiling is a flat ceiling with coved edges and is carved with a crude map that is easily recognizable as the region outside of the dungeon. A stone bookcase about three feet wide and five tall is carved into the wall to your left. The corpse of a partly eaten kobold  lies along the far wall.";
            string roomEight = "You hear the crying of a child as you enter a complex L-shaped room, where the fortified obsidean walls show signs of battle. The polished floor is covered by rat droppings. The room is absent of light, but oil lamps line the wall.";
            string roomNine = "A thick layer of dust covers the warped floor. Torches are alight in this room, blowing with a ghostly purple light. In the far corner you notice a blue viscous liquid suspended ion a bottle.";
            string roomTen = "All you can hear is cackling as you enter a barren room, where the fortified timber walls have missing portions that show through to the earth. Vines and plants grow from the cracks in the stone floor. An unlit chandalier hangs overhead.";
            string roomEleven = "A thick layer of dust covers the floor. Light seems to be eminating from glowing orbs along the wall. It seems like this room is a laboratory.";
            string roomTwelve = "Vines and plants grow from the cracks in the timber floor. Items scattered throughout the room indicate that it may have been an amphitheater. You hear screechs coming from the raised plateform in the corner";
            string roomThirteen = "The hair on the back of your neck stands as you enter a disgusting room. Claw marks run up and down the ancient marble walls. Scattered bones line the old floor. A glow eminates from the opposite side of the room.";
            string roomFourteen = "Blood stains line the fortified marble walls. Dead insects cover the dirt floor and swarms of spiders weave intricate designs in the corner of the abismal room.";
            string roomFifteen = "The stone floor shows signs of a campfire of unknown age. Sunlight trickles into the room. The circular room is earily silent, even your footsteps are not heard.";
            string roomSixteen = "Your footsteps echo as you enter a frigid room. The reinforced obsidean walls are angled 15 degrees outward. A single deteriorated body lies in the center of the crumbling floor.";
            string roomSeventeen = "As you enter this room, you are discombobulated at first as the walls, floor and ceiling are covered in mirrors, some are shattered and glass lay strewn across the floor.";
            string roomEighteen = "Dead vermin cover the ancient floor and a single lantern is lit in the center of the room. This room contains items from a workshop that are haphazardly scattered aound the floor.";
            string roomNineteen = "A fire is seen crackling in the corner of the room. A delisious smell of owl-bear wafts over you as it fills the room with its mouth-watering aroma.";
            string roomTwenty = "Translucent slime covers the walls ceilings and floor of this room. It seems as if a battle of ooze's has taken place in this room and there were heavy casualties. Underneath the slime filled center of the room lies a small sachel.";
            string roomTwentyone = "The room is bathed in a blistering heat coming from a red glowing sphere suspended from the ceiling, your flesh seemingly singes as you traverse around the room.";
            string roomTwentytwo = "The room is pure marble and your footsteps echo as you walk.";
            string roomTwentythree = "There is a cavernous pit that fills the center of the room, watch your step.";
            string roomTwentyfour = "It stinks in here.";
            string roomTwentyfive = "There are a field of flowers of all different colors that adorn the walls, floor, and ceiling of this room.";

            if(roomNumber == 0)
            {
                return roomOne;
            }
            else if(roomNumber == 1)
            {
                return roomTwo;
            }
            else if (roomNumber == 2)
            {
                return roomThree;
            }
            else if (roomNumber == 3)
            {
                return roomFour;
            }
            else if (roomNumber == 4)
            {
                return roomFive;
            }
            else if (roomNumber == 5)
            {
                return roomSix;
            }
            else if (roomNumber == 6)
            {
                return roomSeven;
            }
            else if (roomNumber == 7)
            {
                return roomEight;
            }
            else if (roomNumber == 8)
            {
                return roomNine;
            }
            else if (roomNumber == 9)
            {
                return roomTen;
            }
            else if (roomNumber == 10)
            {
                return roomEleven;
            }
            else if (roomNumber == 11)
            {
                return roomTwelve;
            }
            else if (roomNumber == 12)
            {
                return roomThirteen;
            }
            else if (roomNumber == 13)
            {
                return roomFourteen;
            }
            else if (roomNumber == 14)
            {
                return roomFifteen;
            }
            else if (roomNumber == 15)
            {
                return roomSixteen;
            }
            else if (roomNumber == 16)
            {
                return roomSeventeen;
            }
            else if (roomNumber == 17)
            {
                return roomEighteen;
            }
            else if (roomNumber == 18)
            {
                return roomNineteen;
            }
            else if (roomNumber == 19)
            {
                return roomTwenty;
            }
            else if (roomNumber == 20)
            {
                return roomTwentyone;
            }
            else if (roomNumber == 21)
            {
                return roomTwentytwo;
            }
            else if (roomNumber == 22)
            {
                return roomTwentythree;
            }
            else if (roomNumber == 23)
            {
                return roomTwentyfour;
            }
            else if (roomNumber == 24)
            {
                return roomTwentyfive;
            }
            else
            {
                return "The room is too dark to see";
            }
        }

        //Total encounters 5 nothing rooms, 3 only potion , 4 orc (2 with potion), 2 2orc, 3 2goblin, 2 3goblin (1 with potion)
        //4 banshee, 2 2banshee (1 with potion)

        public static List<string> setGrid()
        {
            List<int> Grid = new List<int>();
            List<string> rooms = new List<string>();
            Grid.Add(0);
            Grid.Add(1);
            Grid.Add(2);
            Grid.Add(3);
            Grid.Add(4);
            Grid.Add(5);
            Grid.Add(6);
            Grid.Add(7);
            Grid.Add(8);
            Grid.Add(9);
            Grid.Add(10);
            Grid.Add(11);
            Grid.Add(12);
            Grid.Add(13);
            Grid.Add(14);
            Grid.Add(15);
            Grid.Add(16);
            Grid.Add(17);
            Grid.Add(18);
            Grid.Add(19);
            Grid.Add(20);
            Grid.Add(21);
            Grid.Add(22);
            Grid.Add(23);
            Grid.Add(24);
            Console.WriteLine(Grid.Count());

            while (Grid.Count > 0)
            {
                int rand = random.Next(0, Grid.Count);
                string one = Rooms(Grid[rand]);
                Grid.RemoveAt(rand);
                rooms.Add(one);
            }

            return rooms;
        }
    }
}
