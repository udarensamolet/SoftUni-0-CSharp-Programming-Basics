using System;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rows = Math.Floor((w * 100 ) / 120); 
            double cols = Math.Floor(((h * 100) - 100) / 70); 

            Console.WriteLine((rows * cols) - 3);
        }
    }
}
