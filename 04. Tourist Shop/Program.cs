using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
           String product = "";
            double sum = 0;
            int count = 0;
            int allCount = 0;
            while (budget>=sum)
            {
                product = Console.ReadLine();
                if (product == "Stop") break;
                double price = double.Parse(Console.ReadLine());
                count++;
                allCount++;
                if (count == 3)
                {
                    price = price / 2;
                    count = 0;
                }
                sum += price;
            }
            if (product == "Stop")
            {
                Console.WriteLine($"You bought {allCount} products for {sum:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {sum-budget:f2} leva!");
            }
        }
    }
}
