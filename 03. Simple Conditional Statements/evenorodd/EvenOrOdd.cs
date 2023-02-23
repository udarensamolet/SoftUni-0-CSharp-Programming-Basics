using System;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
