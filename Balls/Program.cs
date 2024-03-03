using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int othersCount = 0;
            int blackCount = 0;
            double sum = 0;
            for(int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        sum += 5;
                        redCount++;
                        break;
                    case "orange":
                        sum += 10;
                        orangeCount++;
                        break;
                    case "yellow":
                        sum += 15;
                        yellowCount++;
                        break;
                    case "white":
                        sum += 20;
                        whiteCount++;
                        break;
                    case "black":
                        sum = Math.Floor(sum/2);
                        blackCount++;
                        break;
                    default:
                        othersCount++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {sum}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {othersCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");
        }
    }
}
