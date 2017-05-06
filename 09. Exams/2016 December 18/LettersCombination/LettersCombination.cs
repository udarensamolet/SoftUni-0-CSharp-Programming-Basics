using System;

namespace LettersCombination
{
    class LettersCombination
    {
        static void Main()
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var notIncluded = Console.ReadLine();

            int counter = 0;



            for (char i = char.Parse(first); i <= char.Parse(second); i++)
            {
                for (char j = char.Parse(first); j <= char.Parse(second); j++)
                {
                   for (char k = char.Parse(first); k <= char.Parse(second); k++)
                {
                if (i != char.Parse(notIncluded) && j != char.Parse(notIncluded) && k != char.Parse(notIncluded))
                 {
                Console.Write("{0}{1}{2} ", i, j, k);
                           
               
                            counter++;
                            
                       }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
