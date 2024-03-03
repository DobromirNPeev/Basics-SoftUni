using System;

namespace godzillavskong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());
            double set = budget * 0.1;
            if(extras>150)
            {
                outfit=outfit*0.9;
            }
            double priceClothes = extras * outfit;
            double expenses=set+priceClothes;
            if(expenses>budget)
            {
                double leftMoney = expenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {leftMoney:f2} leva more.");

            }
            if (expenses<=budget)
            {
                double leftMoney1 = budget - expenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney1:F2} leva left.");
            }
        }
    }
}
