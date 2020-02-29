using System;

namespace Vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            Int32.TryParse(Console.ReadLine(), out var firstNumber);

            Console.WriteLine("Enter second number:");

            Int32.TryParse(Console.ReadLine(), out var secondNumber);

            if (secondNumber == 0 || firstNumber == 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            var result = (double)firstNumber / secondNumber;
            var wholeNumberResult = firstNumber / secondNumber;

            Console.WriteLine("Currency: {0:C}", result);
            Console.WriteLine("Integer: {0}", result);
            Console.WriteLine("Scientific: {0:E}", result);
            Console.WriteLine("Fixed-point: {0:F}", result);
            Console.WriteLine("Number: {0:N}", result);
            Console.WriteLine("Hexadecimal: {0:X}", wholeNumberResult);
        }
    }
}
