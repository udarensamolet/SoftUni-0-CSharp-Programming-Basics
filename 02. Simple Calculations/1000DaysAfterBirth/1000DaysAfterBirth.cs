using System;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

            DateTime newDate = date.AddDays(1000);

            string output = newDate.ToString(format);

            Console.WriteLine(output);
        }
    }
}
