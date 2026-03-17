using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Car : Vehicle
    {
        private double _fuelCapacity;
        private double _fuel;
        public double FuelConsumptionPer100Km;
        

        public double FuelCapacity
        {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _fuelCapacity = value;
                }
                else
                {
                    Console.WriteLine("FuelCapacity musbet olmalidir");
                }
            }
        }
        public double Fuel
        {
            get
            {
                return _fuel;
            }
            set
            {
                if (value > 0)
                {
                    _fuel = value;
                }
                else
                {
                    Console.WriteLine("Fuel musbet olmalidir");
                }
            }
        }
        public Car(string _brand, string _model, int _year, double _fuelCapacity, double _fuel, double FuelConsumptionPer100Km)
            : base(_brand, _model,_year) 
        {
            FuelCapacity = _fuelCapacity;
            Fuel = _fuel;
            this.FuelConsumptionPer100Km = FuelConsumptionPer100Km;
        }
        public void Refuel(double liters)
        {
            if(_fuel + liters <= _fuelCapacity)
            {
                _fuel += liters;
            }
            else
            {
                Console.WriteLine("Bu qeder benzin doldurmaq olmaz!");
            }
        }


    }
}
