using System;

namespace Vjezba1_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerVariable = new int();
            var longVariable = long.MaxValue;

            try
            {
                integerVariable = checked((int)longVariable);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(longVariable);
            Console.WriteLine(integerVariable);
        }
    }
}
