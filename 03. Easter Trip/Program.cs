using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int expenses = 0;
            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    expenses = 30 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
                else if(dates == "24-27")
                {
                    expenses = 35 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
                else if(dates == "28-31")
                {
                    expenses = 40 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
            }
            else if(destination == "Italy")
            {
                if (dates == "21-23")
                {
                    expenses = 28 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
                else if (dates == "24-27")
                {
                    expenses = 32 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
                else if (dates == "28-31")
                {
                    expenses = 39 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
            }
            else if(destination == "Germany")
            {
                if (dates == "21-23")
                {
                    expenses = 32 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
                else if (dates == "24-27")
                {
                    expenses = 37 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
                else if (dates == "28-31")
                {
                    expenses = 43 * nights;
                    Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");
                }
            }
        }
    }
}
