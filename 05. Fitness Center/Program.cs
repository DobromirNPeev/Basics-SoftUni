using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            double customers = int.Parse(Console.ReadLine());
            int backCount = 0;
            int chestCount = 0;
            int legCount = 0;
            int absCount = 0;
            int proteinShakeCount = 0;
            int proteinBarCount = 0;
            double workoutCount = 0;
            double proteinBuyersCount = 0;
            for(int i = 1; i <= customers; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        backCount++;
                        workoutCount++;
                        break;
                    case "Chest":
                        chestCount++;
                        workoutCount++;
                        break;
                    case "Legs":
                        legCount++;
                        workoutCount++;
                        break;
                    case "Abs":
                        absCount++;
                        workoutCount++;
                        break;
                    case "Protein shake":
                        proteinShakeCount++;
                        proteinBuyersCount++;
                        break;
                    case "Protein bar":
                        proteinBarCount++;
                        proteinBuyersCount++;
                        break;
                }
            }
            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShakeCount} - protein shake");
            Console.WriteLine($"{proteinBarCount} - protein bar");
            double workouters = workoutCount / customers * 100;
            Console.WriteLine($"{workouters:f2}% - work out");
            double proteinBuyers = proteinBuyersCount / customers * 100;
            Console.WriteLine($"{proteinBuyers:f2}% - protein");
        }
    }
}
