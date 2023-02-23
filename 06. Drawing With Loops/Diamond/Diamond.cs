using System;

namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else if (n > 2)
            {
                //even N
                if (n % 2 == 0)
                {
                    //top 
                    for (int row = 0; row < (n - 1) / 2; row++)
                    {

                        Console.Write(new string('-', (n / 2) - row - 1));
                        Console.Write("*");
                        Console.Write(new string('-', row * 2));
                        Console.Write("*");
                        Console.Write(new string('-', (n / 2) - row - 1));
                        Console.WriteLine();
                    }

                    //middle
                    Console.Write("*");
                    Console.Write(new string('-', n - 2));
                    Console.Write("*");
                    Console.WriteLine();

                    //bottom
                    for (int row = (n - 1) / 2 - 1; row >= 0; row--)
                    {
                        Console.Write(new string('-', (n / 2) - row - 1));
                        Console.Write("*");
                        Console.Write(new string('-', row * 2));
                        Console.Write("*");
                        Console.Write(new string('-', (n / 2) - row - 1));
                        Console.WriteLine();
                    }
                }

                //odd N
                else
                {
                    //top
                    for (int row = 0; row < n / 2; row++)
                    {

                        if (row == 0)
                        {
                            Console.Write(new string('-', (n / 2) - row));
                            Console.Write("*");
                            Console.Write(new string('-', (n / 2) - row));
                        }
                        else
                        {
                            Console.Write(new string('-', (n / 2) - row));
                            Console.Write("*");
                            Console.Write(new string('-', (row * 2) - 1));
                            Console.Write("*");
                            Console.Write(new string('-', (n / 2) - row));
                        }
                        Console.WriteLine();
                    }

                    //middle
                    Console.Write("*");
                    Console.Write(new string('-', n - 2));
                    Console.Write("*");
                    Console.WriteLine();

                    //bottom
                    for (int row = n / 2 - 1; row >= 0; row--)
                    {
                        if (row == 0)
                        {
                            Console.Write(new string('-', (n / 2) - row));
                            Console.Write("*");
                            Console.Write(new string('-', (n / 2) - row));
                        }
                        else
                        {
                            Console.Write(new string('-', (n / 2) - row));
                            Console.Write("*");
                            Console.Write(new string('-', (row * 2) - 1));
                            Console.Write("*");
                            Console.Write(new string('-', (n / 2) - row));
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
