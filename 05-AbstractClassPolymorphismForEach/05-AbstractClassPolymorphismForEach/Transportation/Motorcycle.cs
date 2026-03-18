using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Transportation
{
    internal class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }


        public Motorcycle(string Brand, string Model, int Year, string PlateNumber, int EngineCapacity, bool HasSidecar, int MaxSpeed, string Type)
         : base(Brand, Model, Year, PlateNumber)
        {
            this.EngineCapacity = EngineCapacity;
            this.HasSidecar = HasSidecar;
            this.MaxSpeed = MaxSpeed;
            this.Type = Type;
        }
        public void ShowMotorcycleInfo()
        {
            Console.WriteLine($"{Brand}, {Model}, {Year}, {PlateNumber}, {FuelLevel}, {EngineCapacity}, {HasSidecar}, {MaxSpeed}, {Type}");
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }

    }
}
