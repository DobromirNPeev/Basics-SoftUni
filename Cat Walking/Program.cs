using System;

namespace Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minute = int.Parse(Console.ReadLine());
            int dailyWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            minute = minute * dailyWalks;
            int burnedcalories = minute * 5;
            if (calories * 0.5 > burnedcalories)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedcalories}.");
            }
            else
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedcalories}.");
            }
        }
    }
}
