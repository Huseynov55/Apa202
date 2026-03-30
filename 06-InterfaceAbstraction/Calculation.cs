using System;
using System.Collections.Generic;
using System.Text;

namespace _06_InterfaceAbstraction
{
    internal class Calculation : ICalculation
    {
        public double Calculate(double a, double b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Sıfıra bolmek olmaz!");
                    }
                    return a / b;
                default:
                    Console.WriteLine("Yanlış emeliyyat daxil edilib!");
                    return 0;
            }
        }
    }
}
