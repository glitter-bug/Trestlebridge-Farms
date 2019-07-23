using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class PlowedField : IFacility<IPlant> {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid ();

        private List<IPlant> _seeds = new List<IPlant> ();

        public double seedCount { get { return _seeds.Count; } }
        public double Capacity {
            get {
                return _capacity;
            }
        }

        
                public void Groupedseeds () {
                    var collection = _seeds.GroupBy (
                        seed => seed.Type
                    );
                    foreach (var seed in collection) {
                        System.Console.WriteLine ($"{seed.Count()} {seed.Key}(s)");
                    }
                }
        
        public void AddResource (IPlant seed) {
            if (_seeds.Count < Capacity) {
                _seeds.Add (seed);
            } else {
                System.Console.WriteLine ("The facility is at maximum capacity.");
                Console.ReadLine ();
            }
        }

        public void AddResource (List<IPlant> seeds) {
            // TODO: implement this...
            throw new NotImplementedException ();
        }

        public override string ToString () {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append ($"Plowed field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();
        }
    }
}