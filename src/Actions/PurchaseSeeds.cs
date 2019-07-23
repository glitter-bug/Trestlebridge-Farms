using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class PurchaseSeed {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Sesame");
            Console.WriteLine ("2. Ostrich");
            Console.WriteLine ("3. Goat");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse (choice)) {
                case 1:
                    ChoosePlowedField.CollectInput (farm, new Sesame ());
                    break;

                    /*  case 2:
                    ChooseGrazingField.CollectInput (farm, new Ostrich ());
                    break;

                case 3:
                    ChooseGrazingField.CollectInput (farm, new Goat ());
                    break;

          */
            }
        }
    }
}