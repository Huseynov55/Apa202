namespace _06_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculator = new Calculation();

            Console.Write("Birinci ededi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Emeliyyatı daxil edin: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("İkinci ededi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = calculator.Calculate(num1, num2, op);

            Console.WriteLine($"Netice: {result}");


        }
    }
}
