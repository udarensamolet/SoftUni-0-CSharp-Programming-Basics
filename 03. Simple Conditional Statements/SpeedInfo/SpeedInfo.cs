using System;

namespace SpeedInfo
{
    class SpeedInfo
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            if (n <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (n > 10 & n <= 50)
            {
                Console.WriteLine("average");
            }
            else if (n > 50 && n <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (n > 150 && n <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (n > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
