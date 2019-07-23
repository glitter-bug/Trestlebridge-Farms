using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IDuck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IDuck> _animals = new List<IDuck>();

        public double animalCount { get { return _animals.Count; } }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IDuck animal)
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

        public void AddResource(List<IDuck> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}