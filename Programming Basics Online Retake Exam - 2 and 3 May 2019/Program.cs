using System;

namespace Programming_Basics_Online_Retake_Exam___2_and_3_May_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double raspberryQuantity = double.Parse(Console.ReadLine());
            double strawberryQuantity = double.Parse(Console.ReadLine());
            double raspberryPrice = strawberryPrice / 2;
            double orangesPrice = raspberryPrice*0.6;
            double bananaPrice = raspberryPrice*0.2;
            double sum = strawberryPrice * strawberryQuantity + bananasQuantity * bananaPrice + orangesPrice * orangesQuantity + raspberryPrice * raspberryQuantity;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
