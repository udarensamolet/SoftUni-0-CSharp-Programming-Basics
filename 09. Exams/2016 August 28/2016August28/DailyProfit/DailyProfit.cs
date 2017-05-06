using System;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main()
        {
            int daysInMonth = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double currency = double.Parse(Console.ReadLine());

            double profitPerMonth = daysInMonth * moneyPerDay;
            double profitPerYear = profitPerMonth * 12 + profitPerMonth * 2.5;
            double tax = profitPerYear * 0.25;
            double finalProfitPerYear = (profitPerYear - tax) * currency;
            double profitPerDay = finalProfitPerYear / 365;

            Console.WriteLine("{0:f2}", profitPerDay);
        }
    }
}
