using System;

namespace Digits
{
    class Digits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int first = (n / 100) % 10;
            int second = (n / 10) % 10;
            int third = n % 10;

            int rows = first + second;
            int cols = first + third;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - first;
                        Console.Write(n + " ");
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - second;
                        Console.Write(n + " ");
                    }
                    else
                    {
                        n = n + third;
                        Console.Write(n + " "); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
