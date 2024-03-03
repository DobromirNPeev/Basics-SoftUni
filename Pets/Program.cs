using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine()); //kg
            double dogsFood = double.Parse(Console.ReadLine()); //kg
            double catsFood = double.Parse(Console.ReadLine()); //kg
            double turtlesFood = double.Parse(Console.ReadLine()); //g
            double sumFood = (dogsFood + catsFood + (turtlesFood / 1000))*days;
            if (leftFood >= sumFood)
            {
                double diff = leftFood - sumFood;
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
            {
                double diff = sumFood - leftFood;
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }
        }
    }
}
