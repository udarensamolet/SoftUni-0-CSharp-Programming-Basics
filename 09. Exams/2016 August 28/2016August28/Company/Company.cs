using System;

namespace Company
{
    class Company
    {
        static void Main()
        {
            double neededHours = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double overtime = workers * (2 * days);
            days = days - days * 0.10;
            double workedHours = days * 8;
            workedHours = Math.Floor(workedHours + overtime);

            if (workedHours >= neededHours)
            {
                Console.WriteLine("Yes!{0} hours left.", workedHours - neededHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", neededHours - workedHours);
            }

        }
    }
}
