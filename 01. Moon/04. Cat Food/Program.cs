using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());
            double money = 0;
            int small = 0;
            int large = 0;
            int gigantic = 0;
            double allFood = 0;
            for (int i = 0; i < cats; i++)
            {
                double catFood = double.Parse(Console.ReadLine());
                allFood += catFood;
                if(catFood>=100 && catFood < 200)
                {
                    small++;
                }
                else if(catFood >= 200 && catFood < 300)
                {
                    large++;
                }
                else if(catFood >= 300 && catFood < 400)
                {
                    gigantic++;
                }
            }
            allFood /= 1000;
            money = 12.45 * allFood;
            Console.WriteLine($"Group 1: {small} cats.");
            Console.WriteLine($"Group 2: {large} cats.");
            Console.WriteLine($"Group 3: {gigantic} cats.");
            Console.WriteLine($"Price for food per day: {money:f2} lv.");
        }
    }
}
