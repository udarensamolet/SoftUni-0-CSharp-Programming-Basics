using System;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int counterWork = 0;
            int counter = 0;

            double first = 0;
            double second = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    first = double.Parse(Console.ReadLine());
                    counterWork++;
                    counter = counterWork;
                }


                if (i > 0)
                {
                    second = double.Parse(Console.ReadLine());

                    if (second > first)
                    {
                        counterWork++;

                        if (counterWork > counter)
                        {
                            counter = counterWork;
                        }
                    }

                    else
                    {
                        counterWork = 1;
                    }

                    first = second;
                }

               
            }
            Console.WriteLine(counter);
        }
    }
}
