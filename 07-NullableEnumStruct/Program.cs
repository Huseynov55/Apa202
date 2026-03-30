using _07_NullableEnumStruct.Enums;

namespace _07_NullableEnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder s1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            s1.DisplayOrder();
            s1.UpdateStatus(OrderStatus.Preparing);
            s1.UpdateStatus(OrderStatus.Ready);
            s1.UpdateStatus(OrderStatus.Delivered);


            DrinkOrder s2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            s2.DisplayOrder();
            s2.UpdateStatus(OrderStatus.Ready);
            s2.DisplayOrder();


            DrinkOrder s3 = new DrinkOrder(103, "Vuqar", DrinkType.Juice, DrinkSize.Small);
            s3.DisplayOrder();



            Console.WriteLine("İcki Novleri:");
            foreach (DrinkType d in Enum.GetValues(typeof(DrinkType)))
            {
                Console.WriteLine("- " + d);
            }

            Console.WriteLine(DrinkType.Coffee.ToString());


            string strTea = "Tea";
            DrinkType parsedTea = (DrinkType)Enum.Parse(typeof(DrinkType), strTea);
            Console.WriteLine(parsedTea);

            Console.WriteLine("\n--- Statistika ---");
            decimal totalAmount = s1.Price + s2.Price + s3.Price;


            Console.WriteLine($"Umumi sifaris: 3");
            Console.WriteLine($"1-ci sifaris: {s1.Price} AZN");
            Console.WriteLine($"2-ci sifaris: {s2.Price} AZN");
            Console.WriteLine($"3-cu sifaris: {s3.Price} AZN");
            Console.WriteLine($"Umumi mebleg: {totalAmount} AZN");




        }
    }
}
