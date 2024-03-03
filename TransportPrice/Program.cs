using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double taxi = 0.7;
            double bus =0;
            bus = 0.09 * km;
            double train = 0;
            train = 0.06 * km;
            if(km<20)
            {
                if(type=="day")
                {
                    taxi += 0.79 * km;
                }
                else if(type=="night")
                {
                    taxi += 0.90 * km;
                }
                Console.WriteLine($"{taxi:f2}");
            }
            else if(km>=20 && km<100)
            {
                if (type == "day")
                {
                    taxi += 0.79 * km;
                }
                else if (type == "night")
                {
                    taxi += 0.90 * km;
                }
                if(taxi<bus)
                {
                    Console.WriteLine($"{taxi:f2}");
                }
                else
                {
                    Console.WriteLine($"{bus:f2}");
                }
            }
            else if (km >= 100)
            {
                if (type == "day")
                {
                    taxi += 0.79 * km;
                }
                else if (type == "night")
                {
                    taxi += 0.90 * km;
                }
                if(train<bus && train<taxi)
                {
                    Console.WriteLine($"{train:f2}");
                }
                else if(bus<train && bus<taxi)
                {
                    Console.WriteLine($"{bus:f2}");
                }
                else if(taxi<train && taxi<bus)
                {
                    Console.WriteLine($"{taxi:f2}");
                }
            }
        }
    }
}
