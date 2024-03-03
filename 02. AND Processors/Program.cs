using System;

namespace _02._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            int processors = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workeringDays = int.Parse(Console.ReadLine());
            double money = (workers * workeringDays * 8)/3;
            money = Math.Floor(money);
            if (money >= processors)
            {
                Console.WriteLine($"Profit: -> {(money-processors)*110.10:f2} BGN");
            }
            else
            {
                Console.WriteLine($"Losses: -> {(processors-money)*110.10:f2} BGN");
            }
        }
    }
}
