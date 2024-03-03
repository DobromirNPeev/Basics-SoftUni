using System;

namespace ConditionalStatementsAdvanced_MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double transportPrice = 0;
            double ticketPrice = 0;
            double sum = 0;
            if(type=="VIP")
            {
                if(people>=1 && people<=4)
                {
                    transportPrice = 0.75 * budget;
                    ticketPrice = 499.99 * people;
                    sum = transportPrice + ticketPrice;
                    if(sum<=budget)
                    {
                        double diff = budget-sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum-budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 5 && people <= 9)
                {
                    transportPrice = 0.6 * budget;
                    ticketPrice = 499.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 10 && people <= 24)
                {
                    transportPrice = 0.5 * budget;
                    ticketPrice = 499.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 25 && people <= 49)
                {
                    transportPrice = 0.4 * budget;
                    ticketPrice = 499.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 50)
                {
                    transportPrice = 0.25 * budget;
                    ticketPrice = 499.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
            }
            else if (type == "Normal")
            {
                if (people >= 1 && people <= 4)
                {
                    transportPrice = 0.75 * budget;
                    ticketPrice = 249.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 5 && people <= 9)
                {
                    transportPrice = 0.6 * budget;
                    ticketPrice = 249.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 10 && people <= 24)
                {
                    transportPrice = 0.5 * budget;
                    ticketPrice = 249.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 25 && people <= 49)
                {
                    transportPrice = 0.4 * budget;
                    ticketPrice = 249.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
                else if (people >= 50)
                {
                    transportPrice = 0.25 * budget;
                    ticketPrice = 249.99 * people;
                    sum = transportPrice + ticketPrice;
                    if (sum <= budget)
                    {
                        double diff = budget - sum;
                        Console.WriteLine($"Yes! You have {diff:f2} leva left.");
                    }
                    else
                    {
                        double diff = sum - budget;
                        Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
                    }
                }
            }
        }
    }
}
