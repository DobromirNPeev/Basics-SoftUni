using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = magnolias * 3.25;
            double hyacinthsPrice = hyacinths * 4;
            double rosesPrice = roses * 3.50;
            double cactusesPrice = cactuses * 8;

            double sum = (magnoliasPrice + hyacinthsPrice + rosesPrice + cactusesPrice) * 0.95;

            if (sum >= presentPrice)
            {
                double diff = sum - presentPrice;
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }
            else
            {
                double diff = presentPrice - sum;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(diff)} leva.");
            }
        }
    }
}
