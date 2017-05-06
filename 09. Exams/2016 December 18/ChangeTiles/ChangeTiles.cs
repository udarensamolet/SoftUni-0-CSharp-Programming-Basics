using System;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main()
        {
            double haralambiMoney = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTriangleTile = double.Parse(Console.ReadLine());
            double heightTriangleTile = double.Parse(Console.ReadLine());
            double priceTile = double.Parse(Console.ReadLine());
            double priceMaistor = double.Parse(Console.ReadLine());

            double areaFloor = widthFloor * lengthFloor;
            double areaTile = sideTriangleTile * heightTriangleTile / 2;
            double neededTiles = Math.Ceiling(areaFloor / areaTile) + 5;
            double priceAllTiles = neededTiles * priceTile + priceMaistor;

            if (priceAllTiles <= haralambiMoney)
            {
                Console.WriteLine("{0:f2} lv left.", haralambiMoney - priceAllTiles);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", priceAllTiles - haralambiMoney);
            }
        }
    }
}
