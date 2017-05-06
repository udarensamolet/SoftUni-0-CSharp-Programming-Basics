using System;

namespace HousePrice
{
    class HousePrice
    {
        static void Main()
        {
            double smallestArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double priceSqM = double.Parse(Console.ReadLine());

            double bathArea = smallestArea / 2;
            double secondRoomArea = smallestArea * 0.10 + smallestArea;
            double thirdRoomArea = secondRoomArea * 0.10 + secondRoomArea;
            double hallwayArea = (smallestArea + secondRoomArea + thirdRoomArea + kitchenArea + bathArea) * 0.05;

            /*Console.WriteLine(bathArea);
            Console.WriteLine(secondRoomArea);
            Console.WriteLine(thirdRoomArea);
            Console.WriteLine(hallwayArea);*/

            Console.WriteLine("{0:f2}", (smallestArea + secondRoomArea + thirdRoomArea + kitchenArea + bathArea + hallwayArea) * priceSqM);
        }
    }
}
