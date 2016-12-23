using System;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round((amount * 1.79549), 2));
        }
    }
}
