using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("error");
            }
            else
            {
                //top
                Console.Write(new string('*', n * 2));
                Console.Write(new string(' ', n));
                Console.Write(new string('*', n * 2));
                Console.WriteLine();

                //middle
                {
                    for (int row = 1; row <= n - 2; row++)
                    {
                        //left part
                        Console.Write("*");
                        Console.Write(new string('/', (n * 2) - 2));
                        Console.Write("*");

                        //middle part
                        {
                            if (row == (n - 1 ) / 2 )
                            {
                                Console.Write(new string('|', n));
                            }
                            else
                            {
                                Console.Write(new string(' ', n));
                            }
                        }

                        //right part
                        Console.Write("*");
                        Console.Write(new string('/', (n * 2) - 2));
                        Console.Write("*");

                        Console.WriteLine();
                    }
                }

                //bottom
                Console.Write(new string('*', n * 2));
                Console.Write(new string(' ', n));
                Console.Write(new string('*', n * 2));
                Console.WriteLine();
            }
        }
    }
}
