using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x1 < x2 || y1 < y2)
            {
                if ((x == x1 || x == x2 && y > y1 && y < y2) || (x > x1 && x < x2 && y == y1 || y == y2))
                {
                    Console.WriteLine("Border");
                }
                else if (x > x1 && x < x2 && y > y1 && y < y2)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
        }
    }
}
