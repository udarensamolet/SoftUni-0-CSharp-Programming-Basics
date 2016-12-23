using System;

namespace Invalid_Number
{
    class InvalidNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 0 && n < 100 || n > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
