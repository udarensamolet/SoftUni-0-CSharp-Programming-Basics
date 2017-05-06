using System;

namespace HousePainting
{
    class HousePainting
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideSide = x * y;
            double window = 1.5 * 1.5;
            double twoSides = sideSide * 2 - window * 2;
            double backSide = x * x;
            double entrance = 1.2 * 2;
            double frontBack = 2 * backSide - entrance;

            double all = twoSides + frontBack;

            double rectangles = 2 * (x * y);
            double triangles = 2 * (x * h / 2);
            double roof = rectangles + triangles;

            double greenPaint = all / 3.4;
            double redPaint = roof / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
