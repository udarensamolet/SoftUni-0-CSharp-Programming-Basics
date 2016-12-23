using System;


namespace Cinema
{
    class Cinema
    {
        static void Main()
        {
            string movie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int seats = rows * cols;

            if(movie == "Premiere")
            {
                Console.WriteLine("{0:f2} leva", seats * 12.00);
            }
            else if (movie == "Normal")
            {
                Console.WriteLine("{0:f2} leva", seats * 7.50);
            }
            else if (movie == "Discount")
            {
                Console.WriteLine("{0:f2} leva", seats * 5.00);
            }
        }
    }
}
