using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Transportation
{
    internal class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string Brand, string Model, int Year, string PlateNumber, double CargoCapacity, int AxleCount, double CurrentLoad, int MaxSpeed)
        : base(Brand, Model, Year, PlateNumber)
        {
            this.CargoCapacity = CargoCapacity;
            this.AxleCount = AxleCount;
            this.CurrentLoad = CurrentLoad;
            this.MaxSpeed = MaxSpeed;
        }

        public void ShowTruckInfo()
        {
            Console.WriteLine($"{Brand}, {Model}, {Year}, {PlateNumber}, {FuelLevel}, {CargoCapacity}, {AxleCount}, {CurrentLoad}, {MaxSpeed} ");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
            }
            else
            {
                Console.WriteLine($"Limit aşıldı! Maksimum {CargoCapacity} ton yüklene biler.");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
    }
}
