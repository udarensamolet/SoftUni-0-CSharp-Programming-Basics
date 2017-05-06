using System;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();

            double adultsPrice = 0;
            double studentsPrice = 0;

            if (transport == "train")
            {
                if (adults + students >= 50)
                {
                    adultsPrice = adults * 24.99 - adults * 24.99 * 0.5;
                    studentsPrice = students * 14.99 - students * 14.99 * 0.5;
                }
                else
                {
                    adultsPrice = adults * 24.99;
                    studentsPrice = students * 14.99;
                }
            }
            else if (transport == "bus")
            {
                adultsPrice = adults * 32.50;
                studentsPrice = students * 28.50;
            }
            else if (transport == "boat")
            {
                adultsPrice = adults * 42.99;
                studentsPrice = students * 39.99;
            }
            else if (transport == "airplane")
            {
                adultsPrice = adults * 70;
                studentsPrice = students * 50;
            }

            double finalPrice = (adultsPrice + studentsPrice) * 2 + nights * 82.99;
            double com = finalPrice * 0.10;

            Console.WriteLine("{0:f2}", finalPrice + com);

            
        }
    }
}
