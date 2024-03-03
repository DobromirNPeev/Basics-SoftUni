using System;

namespace Programming_Basics_Online_Final_Exam___18_and_19_December_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerPage = double.Parse(Console.ReadLine());
            double pricePerCover = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double designerWage = double.Parse(Console.ReadLine());
            double teamWage = double.Parse(Console.ReadLine());
            double price = pricePerPage * 899 + pricePerCover * 2;
            price = price * (1-(percentage / 100));
            price += designerWage;
            price = price * (1 - (teamWage / 100));
            Console.WriteLine($"Avtonom should pay {price:f2} BGN.");
        }
    }
}
