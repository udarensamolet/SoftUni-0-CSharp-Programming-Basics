using System;

namespace Grades
{
    class Grades
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double grade = 0;

            double averageGrade = 0;

            double count1 = 0; //pod 3.00
            double count2 = 0; //3.00 - 3.99
            double count3 = 0; //4.00 - 4.99
            double count4 = 0; //5.00

            for (int i = 0; i < studentsCount; i++)
            {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;

                if (grade < 3)
                {
                    count1++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    count2++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    count3++;
                }
                else if (grade >= 5.00)
                {
                    count4++;
                }
            }

            Console.WriteLine("Top students: {0:f2}%", count4 / studentsCount * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", count3 / studentsCount * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", count2 / studentsCount * 100);
            Console.WriteLine("Fail: {0:f2}%", count1 / studentsCount * 100);
            Console.WriteLine("Average: {0:f2}", averageGrade / studentsCount);
        }
    }
}
