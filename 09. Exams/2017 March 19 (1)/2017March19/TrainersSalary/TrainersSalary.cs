using System;
namespace TrainersSalary
{
    class trainersSalary
    {
        static void Main()
        {
            double numberOfLessons = double.Parse(Console.ReadLine());
            double butget = double.Parse(Console.ReadLine());

            double lessonPrice = butget / numberOfLessons;

            double JelevMoney = 0;
            double RoYalMoney = 0;
            double RoliMoney = 0;
            double TrofonMoney = 0;
            double SinoMoney = 0;
            double OthersMoney = 0;

            for (int i = 1; i <= numberOfLessons; i++)
            {
                string name = Console.ReadLine().ToLower();

                if (name == "jelev")
                {
                    JelevMoney += lessonPrice;
                }
                else if (name == "royal")
                {
                    RoYalMoney += lessonPrice;
                }
                else if (name == "roli")
                {
                    RoliMoney += lessonPrice;
                }
                else if (name == "trofon")
                {
                    TrofonMoney += lessonPrice;
                }
                else if (name == "sino")
                {
                    SinoMoney += lessonPrice;
                }
                else
                {
                    OthersMoney += lessonPrice;
                }
            }
            Console.WriteLine($"Jelev salary: {JelevMoney:0.00} lv");
            Console.WriteLine($"RoYaL salary: {RoYalMoney:0.00} lv");
            Console.WriteLine($"Roli salary: {RoliMoney:0.00} lv");
            Console.WriteLine($"Trofon salary: {TrofonMoney:0.00} lv");
            Console.WriteLine($"Sino salary: {SinoMoney:0.00} lv");
            Console.WriteLine($"Others salary: {OthersMoney:0.00} lv");
        }
    }
}