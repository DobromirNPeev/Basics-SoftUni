using System;

namespace ForLoopMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double legacy = double.Parse(Console.ReadLine());
            int yearsLived = int.Parse(Console.ReadLine());
            int years = 18;
            for(int i = 1800; i <= yearsLived; i++)
            {
                if (i % 2 == 0)
                {
                    legacy -= 12000;
                    years++;
                }
                else
                {
                    legacy -= 12000 + (50 * years);
                    years++;
                }
            }
            if (legacy >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {legacy:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(legacy):f2} dollars to survive.");
            }
        }
    }
}
