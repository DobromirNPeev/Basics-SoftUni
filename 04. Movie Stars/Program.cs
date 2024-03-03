using System;

namespace _04._Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actor = Console.ReadLine();
            while (actor!="ACTION")
            {
                if (actor.Length <= 15)
                {
                    double wage = double.Parse(Console.ReadLine());
                    budget -= wage;
                    if (budget < 0) break;
                }
                else
                {
                    double wage = budget * 0.2;
                    budget -= wage;
                    if (budget < 0) break;
                }
                actor = Console.ReadLine();
            }
            if (budget<0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva."
);
            }
        }
    }
}
