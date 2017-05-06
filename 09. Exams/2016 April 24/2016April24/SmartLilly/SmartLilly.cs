using System;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main()
        {
            int lillyAge = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            int counterToy = 0;
            double sumReceived = 0;

            for (int i = 1; i <= lillyAge; i++)
            {
                if (i % 2 != 0)
                {
                    counterToy++;
                }
                else
                {
                    sumReceived = sumReceived +  (i * 5) - 1;
                }
            }

            sumReceived = sumReceived + (counterToy * priceToy);

            if (sumReceived >= priceWash)
            {
                Console.WriteLine("Yes! {0:f2}", sumReceived - priceWash);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceWash - sumReceived);
            }
        }
    }
}
