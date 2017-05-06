using System;

namespace Pets
{
    class Pets
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine());

            double allFood = (dog + cat + (turtle / 1000)) * days;

            if (allFood <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - allFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allFood - food));
            }
        }
    }
}
