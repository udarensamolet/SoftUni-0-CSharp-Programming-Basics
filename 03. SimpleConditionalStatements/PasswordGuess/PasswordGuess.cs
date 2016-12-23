using System;

namespace PasswordGuess
{
    class PasswordGuess
    {
        static void Main()
        {
            string pass = "s3cr3t!P@ssw0rd";

            string input = Console.ReadLine();

            if (pass != input)
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
