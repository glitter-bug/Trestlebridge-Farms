using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models {
    public class Farm {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField> ();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse> ();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index) {
            Console.WriteLine (typeof (T).ToString ());
            switch (typeof (T).ToString ()) {
                case "Cow":
                    GrazingFields[index].AddResource ((IGrazing) resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field) {
            GrazingFields.Add (field);
        }
        //Chicken House added here
        public void AddChickenHouse (ChickenHouse field) {
            ChickenHouses.Add (field);
        }

        public override string ToString () {
            StringBuilder report = new StringBuilder ();

            GrazingFields.ForEach (gf => report.Append (gf));

            ChickenHouses.ForEach (ch => report.Append (ch));

            return report.ToString ();
        }
    }
}