using System;

namespace Preparation
{
    class Triangle
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x2 - x3);
            double h = Math.Abs(y2 - y1);

            Console.WriteLine((a * h) / 2);
        }
    }
}
