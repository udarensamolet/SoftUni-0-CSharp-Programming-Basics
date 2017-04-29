using System;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            //top
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.Write("*");
                if (i != 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("-*");
                    }
                }
                Console.WriteLine();
            }

            //middle
            Console.Write("*");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("-*");
            }

            Console.WriteLine();

            //bottom
            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.Write("*");

                if (i != 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("-*");
                    }
                }
                Console.WriteLine();
            }        
        }
    }
}
