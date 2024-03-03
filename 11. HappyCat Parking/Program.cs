using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0;
            double currSum = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if(i%2==0 && (j%2==1 || j==1))
                    {
                        sum += 2.5;
                        currSum += 2.5;
                    }
                   else if(i % 2 == 1 && j % 2 == 0)
                    {
                        sum += 1.25;
                        currSum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                        currSum += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {currSum:f2} leva");
                currSum = 0;
            }
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}
