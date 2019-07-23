using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseFieldNatural
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;


            NaturalFields[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<>(animal, choice);

        }
    }
}