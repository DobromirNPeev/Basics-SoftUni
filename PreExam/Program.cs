using System;

namespace PreExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());
            nights = nights * 20;
            transportCards = 1.60 * transportCards;
            museumTickets = museumTickets * 6;
            double sum = nights + transportCards + museumTickets;
            double allSum = sum * people;
            allSum = 1.25 * allSum;
            Console.WriteLine($"{allSum:f2}");
        }
    }
}
