using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double sum = litres * 2.10 + 100;
            if (day == "Sunday")
            {
                sum = sum * 0.8;
            }
            else
            {
                sum = sum * 0.9;
            }
            if (budget >= sum)
            {
                Console.WriteLine($"Safari time! Money left: {budget-sum:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {sum-budget:f2} lv.");
            }
        }
    }
}
