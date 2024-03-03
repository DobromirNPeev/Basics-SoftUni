using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string prop = Console.ReadLine();
            double sum = 0;
            if (country == "Russia")
            {
                if (prop == "ribbon")
                {
                    sum += 18.5;
                }
                else if(prop == "hoop")
                {
                    sum += 19.1;
                }
                else
                {
                    sum += 18.6;
                }
            }
            else if (country == "Bulgaria")
            {
                if (prop == "ribbon")
                {
                    sum += 19;
                }
                else if (prop == "hoop")
                {
                    sum += 19.3;
                }
                else
                {
                    sum += 18.9;
                }
            }
            else
            {
                if (prop == "ribbon")
                {
                    sum += 18.7;
                }
                else if (prop == "hoop")
                {
                    sum += 18.8;
                }
                else
                {
                    sum += 18.85;
                }
            }
            Console.WriteLine($"The team of {country} get {sum:f3} on {prop}.");
            Console.WriteLine($"{(20-sum)/20*100:f2}%");
        }
    }
}
