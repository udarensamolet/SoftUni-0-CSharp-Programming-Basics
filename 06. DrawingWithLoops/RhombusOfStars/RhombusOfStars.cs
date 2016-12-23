using System;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                //upper part
                for (int row = 1; row < n; row++)
                {
                    Console.Write(new string(' ', n - row));
                    Console.Write("*");
                    for (int i = 0; i < row - 1; i++)
                    {
                        Console.Write(" ");
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                //middle part
                for (int i = 0; i < n; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                //bottom part
                {
                    for (int row = 1; row < n - 1; row++)
                    {
                        Console.Write(new string(' ',row));
                        for (int i = 0; i < n - row; i++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine("*");
                }
            }
        }
    }
}
