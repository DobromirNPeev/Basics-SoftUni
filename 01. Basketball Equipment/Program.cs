using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double fee = double.Parse(Console.ReadLine());
            double trainers = fee * 0.6;
            double jersey = trainers * 0.8;
            double ball = jersey * 0.25;
            double accesories = ball * 0.20;
            double sum = fee + trainers + jersey + ball + accesories;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
