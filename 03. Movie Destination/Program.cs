using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double sum = 0;
            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    sum=(45000*days)*0.7;
                }
                else
                {
                    sum=(40000 * days) * 0.7;
                }
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    sum = (17000 * days) *1.25;
                }
                else
                {
                    sum = (12500 * days) * 1.25;
                }
            }
            else
            {
                if (season == "Winter")
                {
                    sum = 24000 * days;
                }
                else
                {
                    sum = 20250 * days;
                }
            }
            if (budget >= sum)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {sum-budget:f2} leva more!");
            }
        }
    }
}
