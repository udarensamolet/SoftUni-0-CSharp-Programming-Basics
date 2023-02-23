using System;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.PI * r * r);
            Console.WriteLine(2 * Math.PI * r);
        }
    }
}
