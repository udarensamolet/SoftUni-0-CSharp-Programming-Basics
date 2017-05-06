using System;

namespace Cups
{
    class Cups
    {
        static void Main()
        {

            double cupsToBeMade = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            double producedCups = Math.Floor((workers * workingDays * 8) / 5);

            if (producedCups >= cupsToBeMade)
            {
                Console.WriteLine("{0:f2} extra money", (producedCups - cupsToBeMade) * 4.2);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", (cupsToBeMade - producedCups) * 4.2);
            }
        }
    }
}
