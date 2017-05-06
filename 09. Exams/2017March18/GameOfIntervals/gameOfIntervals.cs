using System;

namespace GameOfIntervals
{
    class gameOfIntervals
    {
        static void Main()
        {
            int moves = int.Parse(Console.ReadLine());

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;
            double counter6 = 0;

            double result = 0;

            for (int i = 0; i < moves; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points >= 0 && points <= 9)
                {
                    counter1++;
                    result += points * 20 / 100;
                }
                else if (points >= 10 && points <= 19)
                {
                    counter2++;
                    result += points * 30 / 100;
                }

                else if (points >= 20 && points <= 29)
                {
                    counter3++;
                    result += points * 40 / 100;
                }
                else if (points >= 30 && points <= 39)
                {
                    counter4++;
                    result += 50;
                }
                else if (points >= 40 && points <= 50)
                {
                    counter5++;
                    result += 100;
                }
                else if (points < 0 || points > 50)
                {
                    counter6++;
                    result /= 2;
                }
            }

            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", counter1 / moves * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", counter2 / moves * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", counter3 / moves * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", counter4 / moves * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", counter5 / moves * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", counter6 / moves * 100);
        }
    }
}
