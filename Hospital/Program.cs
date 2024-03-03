using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors++;
                    }
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treated += patients;
                }
                else if (patients > doctors)
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
