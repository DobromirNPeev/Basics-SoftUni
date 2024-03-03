using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            double firmDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double workingHours = Math.Floor((firmDays *0.9) * 8);
            double overtime = Math.Floor(workers * (2 * firmDays));
            if (workingHours + overtime>=neededHours)
            {
                Console.WriteLine($"Yes!{((workingHours+overtime)-neededHours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{(neededHours-(workingHours+overtime))} hours needed.");
            }
        }
    }
}
