using System;

namespace ExcellentOrNot
{
    class ExcellentOrNot
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            if (n > 5.49)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
