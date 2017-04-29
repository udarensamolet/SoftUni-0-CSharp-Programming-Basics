using System;

namespace GeneratingRectangles
{
    class GeneratingRectangles
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int counter = 0;

            int left = 0;
            int right = 0;
            int top = 0;
            int bottom = 0;

            int area = 0;
                    
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    for (int k = i; k <= n; k++)
                    {
                        for (int l = j; l <= n; l++)
                        {
                            
                            left = i;
                            top = j;
                            right = k;
                            bottom = l;
                            
                            area = (right - left) * (bottom - top);

                            if (-n <= left && left < right && right <= n && -n <= top && top < bottom && bottom <= n)
                            {
                                if (area >= m)
                                {
                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", i, j, k, l, area);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
