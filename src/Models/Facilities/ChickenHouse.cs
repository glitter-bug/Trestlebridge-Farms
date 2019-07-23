using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IChicken>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IChicken> _animals = new List<IChicken>();

        public double animalCount { get { return _animals.Count; } }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void GroupedAnimals()
        {
            var collection = _animals.GroupBy(
                animal => animal.Type
            );
            foreach (var animal in collection)
            {
                System.Console.WriteLine($"{animal.Count()} {animal.Key}(s)");
            }
        }

        public void AddResource(IChicken animal)
        {
            if (_animals.Count < Capacity)
            {
                _animals.Add(animal);
            }
            else
            {
                System.Console.WriteLine("The facility is at maximum capacity.");
                Console.ReadLine();
            }
        }

        public void AddResource(List<IChicken> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}