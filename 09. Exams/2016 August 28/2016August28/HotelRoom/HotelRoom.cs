using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int stays = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartament = 0;

            if (month == "may" || month == "october")
            {
                if (stays > 7 && stays <= 14)
                {
                    priceStudio = (50 - 50 * 0.05) * stays;
                    priceApartament = 65 * stays;
                }
                else if (stays > 14)
                {
                    priceStudio = (50 - 50 * 0.30) * stays;
                    priceApartament = (65 - 65 * 0.10) * stays;
                }
                else
                {
                    priceStudio = 50 * stays;
                    priceApartament = 65 * stays;
                }
            }

            else if (month == "june" || month == "september")
            {
                if (stays > 14)
                {
                    priceStudio = (75.20 - 75.20 * 0.20) * stays;
                    priceApartament = (68.70 - 68.70 * 0.10) * stays;
                }
                else
                {
                    priceStudio = 75.20 * stays;
                    priceApartament = 68.70 * stays;
                }
            }

            else if (month == "july" || month == "august")
            {
                if (stays > 14)
                {
                    priceStudio = 76 * stays;
                    priceApartament = (77 - 77 * 0.10) * stays;
                }
                else
                {
                    priceStudio = 76 * stays;
                    priceApartament = 77 * stays;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", priceApartament);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }

    }
}
