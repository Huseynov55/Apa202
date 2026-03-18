using _05_AbstractClassPolymorphismForEach.Transportation;
using System.Runtime.InteropServices.Marshalling;

namespace _05_AbstractClassPolymorphismForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Car car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
            Car car2 = new Car("BMW", "320i", 2022, "99-QQ-999", 4, 480, true, 235);
            Car car3 = new Car("Toyota", "Camry", 2021, "77-CC-777", 4, 524, true, 210);

            //2
            Motorcycle motor1 = new Motorcycle("Yamaha", "R1", 2023, "10-SS-001", 998, false, 299, "Sport");
            Motorcycle motor2 = new Motorcycle("Harley-Davidson", "Fat Boy", 2022, "10-PP-002", 1868, true, 180, "Cruiser");

            //3
            Truck truck1 = new Truck("MAN", "TGX", 2020, "90-TR-240", 18, 3, 12, 120);
            Truck truck2 = new Truck("Volvo", "FH16", 2021, "90-RT-290", 25, 4, 18, 110);

            //4
            Console.WriteLine("            Neqliyyat Melumatlari    ");
            car1.ShowCarInfo();
            Console.WriteLine($"Yanacaq xerci (500km): {car1.CalculateFuelCost(500)}");
            car2.ShowCarInfo();
            Console.WriteLine($"Yanacaq xerci (500km): {car2.CalculateFuelCost(500)}");
            car3.ShowCarInfo();
            Console.WriteLine($"Yanacaq xerci (500km): {car3.CalculateFuelCost(500)}");


            motor1.ShowMotorcycleInfo();
            Console.WriteLine($"Yanacaq xerci (300km): {motor1.CalculateFuelCost(300)}");
            motor2.ShowMotorcycleInfo(); 
            Console.WriteLine($"Yanacaq xerci (300km): {motor2.CalculateFuelCost(300)}");

            truck1.ShowTruckInfo();
            Console.WriteLine($"Yanacaq xerci (800km): {truck1.CalculateFuelCost(800)}");
            truck2.ShowTruckInfo();
            Console.WriteLine($"Yanacaq xerci (800km): {truck2.CalculateFuelCost(800)}");

            //5
            Console.WriteLine("\nBirinci trucka 5 ton elave yüklendi");
            truck1.LoadCargo(5);
            Console.WriteLine($"Yeni yanacaq xerci (800km): {truck1.CalculateFuelCost(800)}");

            //6
            Vehicle[] vehicles = {car1, car2, car3, motor1, motor2, truck1, truck2};
            Console.WriteLine($"\nUmumi neqliyyat sayi: {vehicles.Length}");


            double avgSpeed = (double)(car1.MaxSpeed + car2.MaxSpeed + car3.MaxSpeed + motor1.MaxSpeed + motor2.MaxSpeed + truck1.MaxSpeed + truck2.MaxSpeed) / 7;
            Console.WriteLine($"\nOrta maksimum suret: {avgSpeed}");


            double maxCost = truck1.CalculateFuelCost(800);
            Console.WriteLine($"\nEn yuksek yanacaq xerci - Truck 800km: {maxCost}");




        } 
    }
}
