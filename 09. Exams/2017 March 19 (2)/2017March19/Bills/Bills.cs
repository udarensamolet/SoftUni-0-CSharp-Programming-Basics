using System;

namespace Bills
{
    class Bills
    {
        static void Main()
        {
            int months = int.Parse(Console.ReadLine());

            double sumEl = 0;
            int water = 0;
            int internet = 0;
            double others = 0;
            double sumOthers = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                sumEl += electricity;
                water += 20;
                internet += 15;
                others = (electricity + 35) * 1.2;
                sumOthers += others;
            }

            double average = (sumEl + water + internet + sumOthers) / months;
            Console.WriteLine($"Electricity: {sumEl:0.00} lv");
            Console.WriteLine($"Water: {water:0.00} lv");
            Console.WriteLine($"Internet: {internet:0.00} lv");
            Console.WriteLine($"Other: {sumOthers:0.00} lv");
            Console.WriteLine($"Average: {average:0.00} lv");
        }
    }
}
