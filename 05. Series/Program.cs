using System;

namespace _05._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string series = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                switch (series)
                {
                    case "Thrones":
                        price = price * 0.5;
                        sum += price;
                        break;
                    case "Lucifer":
                        price = price * 0.6;
                        sum += price;
                        break;
                    case "Protector":
                        price = price * 0.7;
                        sum += price;
                        break;
                    case "TotalDrama":
                        price = price * 0.8;
                        sum += price;
                        break;
                    case "Area":
                        price = price * 0.9;
                        sum += price;
                        break;
                    default:
                        sum += price;
                            break;
                }
            }
            if (budget >= sum)
            {
                Console.WriteLine($"You bought all the series and left with {budget-sum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {sum-budget:f2} lv. more to buy the series!");
            }
        }
    }
}
