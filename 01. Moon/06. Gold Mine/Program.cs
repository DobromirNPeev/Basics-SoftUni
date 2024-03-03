using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            double gold = 0;
            for (int i = 0; i < locations; i++)
            {
                gold = 0;
                double dailyAverage = double.Parse(Console.ReadLine());
                int daysAtLocation = int.Parse(Console.ReadLine());
                for (int j = 0; j < daysAtLocation; j++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    gold += goldPerDay;
                }
                gold = gold / daysAtLocation;
                if (gold >= dailyAverage)
                {
                    Console.WriteLine($"Good job! Average gold per day: {gold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {dailyAverage-gold:f2} gold.");
                }
            }
        }
    }
}
