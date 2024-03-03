using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());

            double grapes = X * Y;
            double wineProducing = grapes * 0.4;
            double wineLitres = wineProducing / 2.5;
            if (wineLitres < Z)
            {
                double diff = Z - wineLitres;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else if(wineLitres>=Z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLitres)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLitres-Z)} liters left -> {Math.Ceiling((wineLitres-Z)/numWorkers)} liters per person.");
            }

        }
    }
}
