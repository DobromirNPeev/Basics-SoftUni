using System;

namespace _02._Godzilla_vs._Kong1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double outfitPerExtra = double.Parse(Console.ReadLine());
            double decor = 0.1 * budget;
            double price = outfitPerExtra * extras;
            if (extras > 150)
            {
                price = price * 0.9;
            }
            price += decor;
            if (price > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {price-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-price:f2} leva left.");
            }
        }
    }
}
