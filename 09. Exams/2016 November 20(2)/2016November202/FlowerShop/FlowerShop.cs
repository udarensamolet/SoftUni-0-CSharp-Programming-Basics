using System;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main()
        {
            double magnolii = double.Parse(Console.ReadLine());
            double zumbuli = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double kaktusi = double.Parse(Console.ReadLine());
            double pricePresent = double.Parse(Console.ReadLine());

            double priceOrder = magnolii * 3.25 + zumbuli * 4 + rozi * 3.50 + kaktusi * 8 - 0.05 * (magnolii * 3.25 + zumbuli * 4 + rozi * 3.50 + kaktusi * 8);

            if (priceOrder >= pricePresent)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(priceOrder - pricePresent));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(pricePresent - priceOrder));
            }
        }
    }
}
