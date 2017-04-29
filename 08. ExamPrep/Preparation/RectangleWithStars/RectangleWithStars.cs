using System;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 1)
            {
                //odd N
                if (n % 2 != 0)
                {

                    // top
                    Console.Write(new string('%', 2 * n));
                    Console.WriteLine();

                    // upper middle
                    for (int i = 0; i < n / 2; i++)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.Write("%");
                        Console.WriteLine();
                    }


                    // middle
                    Console.Write("%");
                    Console.Write(new string(' ', (2 * n - 4) / 2));
                    Console.Write("**");
                    Console.Write(new string(' ', (2 * n - 4) / 2));
                    Console.Write("%");
                    Console.WriteLine();

                    // lower middle
                    for (int i = 0; i < n / 2; i++)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.Write("%");
                        Console.WriteLine();
                    }


                    // bottom
                    Console.Write(new string('%', 2 * n));
                    Console.WriteLine();
                }

                //even N
                else 
                {

                    // top
                    Console.Write(new string('%', 2 * n));
                    Console.WriteLine();

                    // upper middle
                    for (int i = 0; i < (n / 2) - 1; i++)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.Write("%");
                        Console.WriteLine();
                    }


                    // middle
                    Console.Write("%");
                    Console.Write(new string(' ', (2 * n - 4) / 2));
                    Console.Write("**");
                    Console.Write(new string(' ', (2 * n - 4) / 2));
                    Console.Write("%");
                    Console.WriteLine();

                    // lower middle
                    for (int i = 0; i < (n  / 2) - 1; i++)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.Write("%");
                        Console.WriteLine();
                    }


                    // bottom
                    Console.Write(new string('%', 2 * n));
                    Console.WriteLine();
                }
            }
        }
    }
}
