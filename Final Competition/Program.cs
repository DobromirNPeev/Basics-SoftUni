using System;

namespace Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = Console.ReadLine();
            double price = 0;
            if (country == "Bulgaria")
            {
                price = points * dancers;
                if (season == "summer")
                {
                    price = price * 0.95;
                }
                else
                {
                    price = price * 0.92;
                }
            }
            else
            {
                price = points * dancers;
                price = price * 1.5;
                if (season == "summer")
                {
                    price = price * 0.90;
                }
                else
                {
                    price = price * 0.85;
                }
            }
            double charity = price * 0.75;
            Console.WriteLine($"Charity - {charity:f2}");
            double left = (price - charity)/dancers;
            Console.WriteLine($"Money per dancer - {left:f2}");
        }
    }
}
