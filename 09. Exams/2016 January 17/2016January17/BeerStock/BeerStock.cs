using System;

namespace BeerStock
{
    class BeerStock
    {
        static void Main()
        {
            long reservedBeers = long.Parse(Console.ReadLine());

            long amountShipment = 0;
            string typeShipment = null;

            bool stop = true;

            long receivedBeers = 0;

            long casesSum = 0;
            long sixpacksSum = 0;
            long beersSum = 0;

            while (stop == true)
            {
                string shipment = Console.ReadLine().ToLower();

                if (shipment == "exam over")
                {
                    stop = false;
                    break;
                }

                string[] words = shipment.Split(' ');

                amountShipment = Int32.Parse(words[0]);
                typeShipment = words[1];

                switch (typeShipment)
                {
                    case "beers": beersSum += amountShipment; break;
                    case "sixpacks": sixpacksSum += amountShipment; break;
                    case "cases": casesSum += amountShipment; break;
                }
            }

            receivedBeers = beersSum + sixpacksSum * 6 + casesSum * 24;
            long brokenBeers = receivedBeers / 100;

            long usefulBeers = receivedBeers - brokenBeers;

            if (usefulBeers >= reservedBeers)
            {
                long amountLeft = usefulBeers - reservedBeers;

                long casesLeft = amountLeft / 24;
                long sixpacksLeft = (amountLeft % 24) / 6;
                long beersLeft = (amountLeft % 24) % 6;

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, beersLeft);
            }
            else
            {
                long neededAmount = reservedBeers - usefulBeers;

                long casesLeft = neededAmount / 24;
                long sixpacksLeft = (neededAmount % 24) / 6;
                long beersLeft = (neededAmount % 24) % 6;

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, beersLeft);
            }
        }
    }
}
