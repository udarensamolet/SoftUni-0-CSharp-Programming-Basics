using System;

namespace BackToThePas
{
    class BackToThePast
    {
        static void Main()
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int counter = 17;

            for (int i = 1800; i <= year; i++)
            {
                counter++;
                if (i % 2 == 0)
                {
                    heritage = heritage - 12000;
                }
                else
                {
                    heritage = heritage - (12000 + 50 * counter);
                }
            }

            if (heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritage));
            }
        }
    }
}
