using System;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());

            uint answer = 0;

            int counterA = 0;
            int counterB = 0;
            int counterC = 0;
            int counterD = 0;

            string answers = null;
                   
            for (int i = 0; i < n; i++)
            {
                answer = uint.Parse(Console.ReadLine());

                if (answer % 4 == 0)
                {
                    answers = answers + "a ";
                    counterA++;
                }

                else if (answer % 4 == 1)
                {
                    answers = answers + "b ";
                    counterB++;
                }

                else if (answer % 4 == 2)
                {
                    answers = answers + "c ";
                    counterC++;
                }

                else if (answer % 4 == 3)
                {
                    answers = answers + "d ";
                    counterD++;
                }
            }

            Console.WriteLine(answers);
            Console.WriteLine("Answer A: {0}", counterA);
            Console.WriteLine("Answer B: {0}", counterB);
            Console.WriteLine("Answer C: {0}", counterC);
            Console.WriteLine("Answer D: {0}", counterD);
        }
    }
}
