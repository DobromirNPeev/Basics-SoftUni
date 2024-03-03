using System;

namespace PracticeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seniorTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double ticketSeniorPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double tickedKidPrice = ticketSeniorPrice * 0.3;

            double sum = (seniorTickets * (ticketSeniorPrice+tax)) + (kidTickets * (tickedKidPrice+tax));
            double final = sum * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {final:f2} lv.");


        }
    }
}
