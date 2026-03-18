using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Transportation
{
    internal class Car : Vehicle
    {

        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string Brand, string Model, int Year, string PlateNumber, int DoorsCount, int TrunkCapacity, bool IsAutomatic, int MaxSpeed)
        : base(Brand, Model, Year, PlateNumber)
        {
            this.DoorsCount = DoorsCount;
            this.TrunkCapacity = TrunkCapacity;
            this.IsAutomatic = IsAutomatic;
            this.MaxSpeed = MaxSpeed;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"{Brand}, {Model}, {Year}, {PlateNumber}, {FuelLevel}, {DoorsCount}, {TrunkCapacity}, {IsAutomatic}, {MaxSpeed}");
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
               
        }

    }
}
