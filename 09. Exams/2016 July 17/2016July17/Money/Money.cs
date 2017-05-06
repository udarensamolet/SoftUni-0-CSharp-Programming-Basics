using System;

namespace Money
{
    class Money
    {
        static void Main()
        {
            double bitCoin = double.Parse(Console.ReadLine());
            double chineese = double.Parse(Console.ReadLine());
            double com = double.Parse(Console.ReadLine());

            double bitCoinEuro = bitCoin * 1168 / 1.95;
            double chineeseEuro = ((chineese * 0.15) * 1.76)/ 1.95;

            Console.WriteLine((bitCoinEuro + chineeseEuro) - ((bitCoinEuro + chineeseEuro) * com / 100));
        }
    }
}
