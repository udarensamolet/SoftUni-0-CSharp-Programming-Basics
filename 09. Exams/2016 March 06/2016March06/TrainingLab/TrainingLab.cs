using System;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            if (3 <= w && w <= h && h <= 100)
            {
                double seatsW = Math.Floor((((w * 100) - 100) / 70));
                double seatsH = Math.Floor(h * 100 / 120);
                Console.WriteLine((seatsW * seatsH) - 3);
            }
        }
    }
}
