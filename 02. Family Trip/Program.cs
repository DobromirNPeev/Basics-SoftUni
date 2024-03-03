using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            double additionalExpenses = int.Parse(Console.ReadLine());
            if (nights > 7)
            {
                nightPrice = nightPrice * 0.95;
            }
            double sum = nights * nightPrice;
            double percentage = budget * (additionalExpenses / 100);
            sum += percentage;
            if (sum > budget)
            {
                Console.WriteLine($"{sum-budget:f2} leva needed.");
            }
            else
            {
                Console.WriteLine($"Ivanovi will be left with {budget-sum:f2} leva after vacation.");
            }

        }
    }
}
