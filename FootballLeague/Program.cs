using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = int.Parse(Console.ReadLine());
            double fanNum = int.Parse(Console.ReadLine());
            double A = 0;
            double B = 0;
            double V = 0;
            double G = 0;
            for(int i = 1; i <= fanNum; i++)
            {
                char sector =char.Parse(Console.ReadLine());
                if (sector == 'A')
                {
                    A++;
                }
                else if (sector == 'B')
                {
                    B++;
                }
                else if(sector == 'V')
                {
                    V++;
                }
                else if (sector == 'G')
                {
                    G++;
                }
            }
            Console.WriteLine($"{A/fanNum*100:F2}%");
            Console.WriteLine($"{B/fanNum*100:f2}%");
            Console.WriteLine($"{V/fanNum*100:f2}%");
            Console.WriteLine($"{G/fanNum*100:f2}%");
            Console.WriteLine($"{fanNum/capacity*100:f2}%");
        }
    }
}
