using System;

namespace Number0To100ToText
{
    class Number0To100ToText
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                if (n >= 0 && n <= 9)
                {
                    switch (n)
                    {
                        case 0: Console.WriteLine("zero"); break;
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                    }
                }
                else if (n >= 11 & n <= 19)
                {
                    switch (n)
                    {
                        case 11: Console.WriteLine("eleven"); break;
                        case 12: Console.WriteLine("twelve"); break;
                        case 13: Console.WriteLine("thirteen"); break;
                        case 14: Console.WriteLine("fourteen"); break;
                        case 15: Console.WriteLine("fifteen"); break;
                        case 16: Console.WriteLine("sixteen"); break;
                        case 17: Console.WriteLine("seventeen"); break;
                        case 18: Console.WriteLine("eighteen"); break;
                        case 19: Console.WriteLine("nineteen"); break;
                    }
                }
                else if (n % 10 == 0)
                {
                    int quotient = n / 10;
                    int remainder = n % 10;

                    switch (quotient)
                    {
                        case 1: Console.WriteLine("ten"); break;
                        case 2: Console.WriteLine("twenty"); break;
                        case 3: Console.WriteLine("thirty"); break;
                        case 4: Console.WriteLine("fourty"); break;
                        case 5: Console.WriteLine("fifty"); break;
                        case 6: Console.WriteLine("sixty"); break;
                        case 7: Console.WriteLine("seventy"); break;
                        case 8: Console.WriteLine("eightty"); break;
                        case 9: Console.WriteLine("ninty"); break;
                        case 10: Console.WriteLine("one hundred"); break;
                    }
                }
                else if (n > 20 && n < 100)
                {
                    int quotient = n / 10;
                    int remainder = n % 10;
                    string quotientString = null;
                    string remainderString = null;

                    switch (quotient)
                    {
                        case 2: quotientString = "twenty"; break;
                        case 3: quotientString = "thirty"; break;
                        case 4: quotientString = "fourty"; break;
                        case 5: quotientString = "fifty"; break;
                        case 6: quotientString = "sixty"; break;
                        case 7: quotientString = "seventy"; break;
                        case 8: quotientString = "eighty"; break;
                        case 9: quotientString = "ninety"; break;
                    }

                    switch (remainder)
                    {
                        case 1: remainderString = "one"; break;
                        case 2: remainderString = "two"; break;
                        case 3: remainderString = "three"; break;
                        case 4: remainderString = "four"; break;
                        case 5: remainderString = "five"; break;
                        case 6: remainderString = "six"; break;
                        case 7: remainderString = "seven"; break;
                        case 8: remainderString = "eight"; break;
                        case 9: remainderString = "nine"; break;
                    }
                    Console.WriteLine(quotientString + " " + remainderString);
                }
            }
        }
    }
}
