using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double salary = 0;
            if (season == "Spring")
            {
                if (kmPerMonth <= 5000)
                {
                    salary = kmPerMonth * 0.75*4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if(kmPerMonth>5000 && kmPerMonth <= 10000)
                {
                    salary = kmPerMonth * 0.95 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if(kmPerMonth>10000 && kmPerMonth <= 20000)
                {
                    salary = kmPerMonth * 1.45 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
            else if(season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    salary = kmPerMonth * 0.9 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    salary = kmPerMonth * 1.1 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    salary = kmPerMonth * 1.45 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    salary = kmPerMonth * 1.05 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    salary = kmPerMonth * 1.25 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    salary = kmPerMonth * 1.45 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
            else if (season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    salary = kmPerMonth * 0.75 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    salary = kmPerMonth * 0.95 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    salary = kmPerMonth * 1.45 * 4;
                    salary = salary * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
        }
    }
}
