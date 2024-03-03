using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int count = 2;
            int sum1 = 0;
            int cashCount = 0;
            int cardCount = 0;
            double cashSum = 0;
            double cardSum = 0;
            string text = Console.ReadLine();
            while(text!="End" && sum1 < sum)
            {
                int num = int.Parse(text);
                if (count % 2 == 0)
                {
                    if (num > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sum1 += num;
                        count++;
                        cashCount++;
                        cashSum += num;
                    }
                }
                else
                {
                    if (num < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sum1 += num;
                        count++;
                        cardCount++;
                        cardSum += num;
                    }
                }
                if (sum1 >= sum) break;
                text = Console.ReadLine();
            }
            if (sum1 >= sum)
            {
                Console.WriteLine($"Average CS: {cashSum / cashCount:f2}");
                Console.WriteLine($"Average CC: {cardSum/cardCount:f2}");
            }
            else if(text=="End")
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }
    }
}
