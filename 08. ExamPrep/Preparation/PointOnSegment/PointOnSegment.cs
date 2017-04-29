using System;

namespace PointOnSegment
{
    class PointOnSegment
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());

            if (x3 == Math.Min(x1, x2) || x3 == Math.Max(x1, x2))
            {
                Console.WriteLine("in");
            }
            
            else if (x3 > Math.Min(x1, x2) && x3 < Math.Max(x1, x2))
            {
                Console.WriteLine("in");
            }
            else 
            {
                Console.WriteLine("out");
            }
            
            if (Math.Abs(x3 - Math.Min(x1,x2)) > Math.Abs(x3 - Math.Max(x1,x2)))
            {
                Console.WriteLine(Math.Abs(x3 - Math.Max(x1,x2)));
            }
            else 
            {
                Console.WriteLine(Math.Abs(x3 - Math.Min(x1,x2)));
            }
        }
    }
}
