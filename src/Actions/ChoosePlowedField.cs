using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChoosePlowedField {
        public static void CollectInput (Farm farm, IPlant seed) {
            Console.Clear ();

            for (int i = 0; i < farm.PlowedFields.Count; i++) {
                Console.WriteLine ($"{i + 1}. Plowed Field has ({farm.PlowedFields[i].seedCount}/{farm.PlowedFields[i].Capacity})");
                System.Console.WriteLine ();
                farm.PlowedFields[i].Groupedseeds ();
                System.Console.WriteLine ();
            }

            Console.WriteLine ();

            // How can I output the type of seed chosen here?
            Console.WriteLine ($"Place the {seed.Type}(s) where?");

            Console.Write ("> ");
            int choice = Int32.Parse (Console.ReadLine ()) - 1;

            farm.PlowedFields[choice].AddResource (seed);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IPlant>(seed, choice);

        }
    }
}