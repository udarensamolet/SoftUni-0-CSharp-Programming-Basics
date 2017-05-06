using System;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (n < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine(Math.Round(0.70 + (n * 0.79), 2));
                }
                else if (time == "night")
                {
                    Console.WriteLine(Math.Round(0.70 + (n * 0.90), 2));
                }
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(Math.Round(n * 0.09, 2));
            }

            else if (n >= 100)
            {
                Console.WriteLine(Math.Round(n * 0.06, 2));
            }
        }
    }
}
