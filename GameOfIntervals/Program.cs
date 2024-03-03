using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double moves = double.Parse(Console.ReadLine());
            int zeroToNine = 0;
            int tentoNineteen = 0;
            int twentyToTwentynine = 0;
            int thirtyToThirtynine = 0;
            int fortyToFifty = 0;
            int invalidCount = 0;
            double sum = 0;
            for(int i = 1; i <= moves; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num>=0 && num <= 9)
                {
                    sum += 0.2 * num;
                    zeroToNine++;
                }
                else if(num>=10 && num <= 19)
                {
                    sum += 0.3 * num;
                    tentoNineteen++;
                }
                else if(num>=20 && num <= 29)
                {
                    sum += 0.4 * num;
                    twentyToTwentynine++;
                }
                else if(num>=30 && num <= 39)
                {
                    sum += 50;
                    thirtyToThirtynine++;
                }
                else if(num>=40 && num <= 50)
                {
                    sum += 100;
                    fortyToFifty++;
                }
                else if(num<0 || num > 50)
                {
                    sum = sum / 2;
                    invalidCount++;
                }
            }
            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"From 0 to 9: {zeroToNine/moves*100:f2}%");
            Console.WriteLine($"From 10 to 19: {tentoNineteen/moves*100:f2}%");
            Console.WriteLine($"From 20 to 29: {twentyToTwentynine/moves*100:f2}%");
            Console.WriteLine($"From 30 to 39: {thirtyToThirtynine/moves*100:f2}%");
            Console.WriteLine($"From 40 to 50: {fortyToFifty/moves*100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidCount/moves*100:f2}%");
        }
    }
}
