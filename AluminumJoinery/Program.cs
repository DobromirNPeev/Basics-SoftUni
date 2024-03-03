using System;

namespace AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJoineries = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            string delivery = Console.ReadLine();
            double sum = 0;
            if (numJoineries < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else if (text == "90X130")
            {
                sum = numJoineries * 110;
                if (numJoineries > 30 && numJoineries <= 60)
                {
                    sum = sum * 0.95;
                }
                else if (numJoineries > 60)
                {
                    sum = sum * 0.92;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
                else if (delivery == "Without delivery")
                {
                    sum = sum;
                }
                if (numJoineries > 99)
                {
                    sum = sum * 0.96;
                }
                Console.WriteLine($"{sum:f2} BGN");
            }
            else if (text == "100X150")
            {
                sum = numJoineries * 140;
                if (numJoineries > 40 && numJoineries <= 80)
                {
                    sum = sum * 0.94;
                }
                else if (numJoineries > 80)
                {
                    sum = sum * 0.90;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
                else if (delivery == "Without delivery")
                {
                    sum = sum;
                }
                if (numJoineries > 99)
                {
                    sum = sum * 0.96;
                }
                Console.WriteLine($"{sum:f2} BGN");
            }
            else if (text == "130X180")
            {
                sum = numJoineries * 190;
                if (numJoineries > 20 && numJoineries <= 50)
                {
                    sum = sum * 0.93;
                }
                else if (numJoineries > 50)
                {
                    sum = sum * 0.88;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
                else if (delivery == "Without delivery")
                {
                    sum = sum;
                }
                if (numJoineries > 99)
                {
                    sum = sum * 0.96;
                }
                Console.WriteLine($"{sum:f2} BGN");
            }
            else if (text == "200X300")
            {
                sum = numJoineries * 250;
                if (numJoineries > 25 && numJoineries <= 50)
                {
                    sum = sum * 0.91;
                }
                else if (numJoineries > 50)
                {
                    sum = sum * 0.86;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
                else if (delivery == "Without delivery")
                {
                    sum = sum;
                }
                if (numJoineries > 99)
                {
                    sum = sum * 0.96;
                }
                Console.WriteLine($"{sum:f2} BGN");
            }
        }
    }
}
