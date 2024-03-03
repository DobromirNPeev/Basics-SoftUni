using System;

namespace _01._Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int cinemaProfit = int.Parse(Console.ReadLine());
            double sum = tickets * priceTicket;
            sum = sum * days;
            sum -= sum * cinemaProfit / 100;
            Console.WriteLine($"The profit from the movie {movie} is {sum:f2} lv.");
        }
    }
}
