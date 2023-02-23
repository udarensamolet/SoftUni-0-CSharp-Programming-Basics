using System;

namespace House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("error");
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine("**");
                    Console.WriteLine("||");
                }

                else if (n > 2)
                {
                    //roof
                    for (int row = 1; row <= ((n + 1) / 2); row++)
                    {
                        if (n % 2 == 0)
                        {
                            Console.Write(new string('-', (n / 2) - row));
                            Console.Write(new string('*', row * 2));
                            Console.Write(new string('-', (n / 2) - row));
                        }
                        else
                        {
                            Console.Write(new string('-', ((n + 1) / 2) - row));
                            Console.Write(new string('*', row * 2 - 1));
                            Console.Write(new string('-', ((n + 1) / 2) - row));
                        }
                        Console.WriteLine();
                    }

                    //base
                    for (int row = 0; row < n / 2; row++)
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.Write("|");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
