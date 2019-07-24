using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public List<PlowedField> PlowedFields {get; } = new List<PlowedField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource((IChicken)resource);
                    break;
                case "Duck":
                    DuckHouses[index].AddResource((IDuck)resource);
                    break;
                    
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
        //Chicken House added here
        public void AddChickenHouse(ChickenHouse field)
        {
            ChickenHouses.Add(field);
        }
        public void AddDuckHouse(DuckHouse field)
        {
            DuckHouses.Add(field);
        }
        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            ChickenHouses.ForEach(ch => report.Append(ch));

            DuckHouses.ForEach(dh => report.Append(dh));

            PlowedFields.ForEach(pf => report.Append(pf));

            return report.ToString();
        }
    }
}