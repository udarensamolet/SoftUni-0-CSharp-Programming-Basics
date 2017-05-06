using System;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;

            int sum = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sum += people;

                if (people <= 5)
                {
                    counter1 += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    counter2 += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    counter3 += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    counter4 += people;
                }
                else if (people >= 41)
                {
                    counter5 += people;
                }
            }

            Console.WriteLine("{0:f2}%", counter1 / sum * 100);
            Console.WriteLine("{0:f2}%", counter2 / sum * 100);
            Console.WriteLine("{0:f2}%", counter3 / sum * 100);
            Console.WriteLine("{0:f2}%", counter4 / sum * 100);
            Console.WriteLine("{0:f2}%", counter5 / sum * 100);
        }
    }
}
