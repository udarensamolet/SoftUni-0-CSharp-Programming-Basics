using System;

namespace Hospital
{
    class Hospital
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatients = 0;

            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }


                }

                if (patients <= doctors)
                {
                    treatedPatients = patients + treatedPatients;
                }
                else
                {
                    treatedPatients = doctors + treatedPatients;
                    untreatedPatients = patients - doctors + untreatedPatients;
                }

            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
