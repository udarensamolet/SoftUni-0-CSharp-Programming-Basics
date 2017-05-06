using System;

namespace GrapeAndRakia
{
    class grapeAndRakia
    {
        static void Main()
        {
            double grapesArray = double.Parse(Console.ReadLine());
            double kgFromM2 = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double grapes = grapesArray * kgFromM2;
            double rest = grapes - brak;

            double forSails = rest * 0.55;
            double forRakia = rest * 0.45;

            double rakia = (forRakia / 7.5) * 9.8;
            double sails = forSails * 1.5;

            Console.WriteLine($"{rakia:0.00}");
            Console.WriteLine($"{sails:0.00}");
        }
    }
}
