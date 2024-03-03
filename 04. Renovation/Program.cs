using System;

namespace _04._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double area =width*height*4;
            area = Math.Ceiling(area - (area / 100 * percentage));
            string paint = "0";
            double sum = 0;
            while (area > sum)
            {
                paint = Console.ReadLine();
                if (paint == "Tired!") break;
                int paint1 = int.Parse(paint);
                sum += paint1;
            }
            if (sum == area)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            else if (paint == "Tired!")
            {
                Console.WriteLine($"{area - sum} quadratic m left.");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {sum - area} l paint left!");
            }
        }
    }
}
