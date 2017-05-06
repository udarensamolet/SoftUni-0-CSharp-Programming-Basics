using System;

namespace MasterHerbalist
{
    class MasterHerbalist
    {
        static void Main()
        {
            int expensesPerDay = int.Parse(Console.ReadLine());

            bool seasonOver = true;

            int hours = 0;
            string path = null;
            int price = 0;

            int counter = 0;
            double profit = 0;
            int days = 0;

            while (seasonOver == true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "season over")
                {
                    seasonOver = false;
                    break;
                }

                string[] separated = input.Split(' ');
                hours = Int32.Parse(separated[0]);
                path = separated[1];
                price = Int32.Parse(separated[2]);

                //nqma vreme za inteligentno reshenie
                string newPath = path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path + path;

                for (int i = 0; i < hours; i++)
                {
                    if (newPath[i] == 'h')
                    {
                        counter++;
                    }
                }

                profit = profit + (counter * price);
                days++;
                counter = 0;
            }

            double profitPerDay = profit / days;

            if (profitPerDay >= expensesPerDay)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", profitPerDay - expensesPerDay);
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}.", expensesPerDay * days - profit);
            }
        }
    }
}
