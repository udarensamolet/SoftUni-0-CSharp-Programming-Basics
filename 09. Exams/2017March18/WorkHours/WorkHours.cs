using System;

namespace WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            double neededHours = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            double hours = workers * workingDays * 8;

            if (hours >= neededHours)
            {
                Console.WriteLine("{0} hours left", hours - neededHours);
            }
            else
            {
                Console.WriteLine("{0} overtime", neededHours - hours);
                Console.WriteLine("Penalties: {0}", (neededHours - hours) * workingDays);
            }
        }
    }
}
