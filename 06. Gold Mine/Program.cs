using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            double expectedGold = 0;
            double gold = 0;
            double sum = 0;
            for (int i = 1; i <= locations; i++)
            {
                expectedGold = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int j = 1; j <= days; j++)
                {
                    gold = double.Parse(Console.ReadLine());
                    sum += gold;
                }
                sum = sum / days;
                if (sum >= expectedGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {sum:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedGold-sum:f2} gold.");
                }
                sum = 0;
            }
        }
    }
}
