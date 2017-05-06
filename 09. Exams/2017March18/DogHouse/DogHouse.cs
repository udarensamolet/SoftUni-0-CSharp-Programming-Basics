using System;

namespace DogHouse
{
    class DogHouse
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double twoSides = (a * (a / 2)) * 2;
            double square = (a / 2) * (a / 2);
            double triangle = ((a / 2) * (b - a / 2)) / 2;
            double backSide = square + triangle;
            double entrance = (a / 5) * (a / 5);
            double frontSide = backSide - entrance;
            double all = twoSides + backSide + frontSide;
            double roof = (a * (a / 2)) * 2;

            double greenPaint = all / 3;
            double redPaint = roof / 5;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
