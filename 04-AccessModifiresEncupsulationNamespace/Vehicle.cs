using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;
        public double MileageKm;
        public bool IsRunning;




        public string Brand 
        { 
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Minimum 3 simvol olmalidir.");
                }
            }
        }
        public string Model 
        { 
            get 
            {
                return _model;
            }
            set
            {

                if (value.Length >= 3)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Minimum 3 simvol olmalidir.");
                }
            } 
        }
        
        public int Year 
        { 
            get
            {
                return _year;
            }
            set 
            {
                if (value > 1900)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("1900den boyuk olmalidir");
                }
            
            } 
        }
        public Vehicle(string _brand, string _model, int _year)
        {
            this._brand = _brand;
            this._model = _model;   
            this._year = _year; 
        }
        public void StartEngine()
        {
            IsRunning = true;
            Console.WriteLine("muherrik ise dusdu");
        }
        public void StopEngine()
        {
            IsRunning= false;
            Console.WriteLine("muherrik sonuludur");
        }
        public void Drive(int km)
        {
            if (IsRunning == true)
            {
                MileageKm += km;

            }
            else
            {
                Console.WriteLine("Muherrik sonuludur");
            }

        }
        public void VehicleInfo()
        {
            Console.WriteLine($" Brand:{_brand} \n Model:{_model}\nYear:{_year}\nMileage:{MileageKm}\nRunning:{IsRunning}");
        }




    }
}
