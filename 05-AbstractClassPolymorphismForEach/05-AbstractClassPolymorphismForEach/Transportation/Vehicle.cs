using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Transportation
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }

        public Vehicle(string Brand, string Model, int Year, string PlateNumber)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
            this.PlateNumber = PlateNumber;
            this.FuelLevel = 100;
        }
        public string GetVehicleInfo()
        {
            return $"{Brand}, {Model}, {Year}, {PlateNumber}, {FuelLevel}";
        }
        public void ShowBasicInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
    }
}
