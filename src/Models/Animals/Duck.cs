using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IDuck, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 18.25;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Duck";
        public string TypeOfAnimal { get; } = "Duck";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack Quack!";
        }
    }
}