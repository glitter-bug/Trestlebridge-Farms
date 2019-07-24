using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlant>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        public double Capacity 
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPlant resource)
        {
            throw new NotImplementedException();
        }

        public void AddResource(List<IPlant> resources)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed Field {shortId} has 0 seeds\n");

            return output.ToString();
        }
    }
}