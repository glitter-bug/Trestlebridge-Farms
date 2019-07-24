using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Chicken House");
            Console.WriteLine("3. Duck House");
            Console.WriteLine("4. Plowed field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("You created a new Grazing farm!");
                    Console.WriteLine("Press Enter to go to the main Menu");
                    Console.ReadLine();
                    break;
                case 2:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("You created a new Chicken House!");
                    Console.WriteLine("Press Enter to go to the main Menu");
                    Console.ReadLine();
                    break;
                case 3:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("You created a new Duck House!");
                    Console.WriteLine("Press Enter to go to the main Menu");
                    Console.ReadLine();
                    break;
                case 4:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("Yeah created n new Plowed Field");
                    Console.WriteLine("Press Enter to go to the main Menu");

            }
        }
    }
}