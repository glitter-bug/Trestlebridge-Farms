using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IDuck animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House has ({farm.DuckHouses[i].animalCount}/{farm.DuckHouses[i].Capacity})");
                System.Console.WriteLine();
                farm.DuckHouses[i].GroupedAnimals();
                System.Console.WriteLine();
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal.Type}(s) where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;


            farm.DuckHouses[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}