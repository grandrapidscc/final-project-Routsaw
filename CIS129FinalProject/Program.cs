using CIS129FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static Wizart currentGame = new Wizart();

    static void Main(string[] args)
    {
        Start();
        List<string> grid = new List<string>(DungeonGrid.setGrid());
        Console.WriteLine(grid.Count());
    
    }
    static void Start()
    {
        Console.WriteLine("Wizert 5: Rabid Hunt");
        Console.WriteLine("");
        Console.WriteLine("Welcome Wizart, great and powerful wizard. Prepare yourself for the ultimate test!");
        Console.WriteLine("");
        Console.WriteLine("Your eyes feel heavy and your muscles are fatigued. \"Where am I?\", you think to yourself as you pick yourself up off the cold and stony ground.");
        Console.WriteLine("");
        Console.WriteLine("Press any key to begin your dungeoneering adventure!");
        Console.ReadKey();
        Console.Clear();
    }


}