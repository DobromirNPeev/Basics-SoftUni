using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entryPrice = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());
            double peopleEntry = people * entryPrice;
            double peopleUmbrella = Math.Ceiling(people * 0.5);
            peopleUmbrella = peopleUmbrella * umbrellaPrice;
            double peopleLounge = Math.Ceiling(people * 0.75);
            peopleLounge = peopleLounge * loungePrice;
            double sum = peopleEntry + peopleLounge + peopleUmbrella;
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
