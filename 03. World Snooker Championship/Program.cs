using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            string trophy = Console.ReadLine();
            double sum = 0;
            if (stage == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    sum = tickets * 55.50;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
                else if (ticketType == "Premium")
                {
                    sum = tickets * 105.20;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
                else if (ticketType == "VIP")
                {
                    sum = tickets * 118.90;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
            }
            else if (stage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    sum = tickets * 75.88;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
                else if (ticketType == "Premium")
                {
                    sum = tickets * 125.22;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
                else if (ticketType == "VIP")
                {
                    sum = tickets * 300.40;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets*40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
            }
            else if (stage == "Final")
            {
                if (ticketType == "Standard")
                {
                    sum = tickets * 110.10;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
                else if (ticketType == "Premium")
                {
                    sum = tickets * 160.66;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
                else if (ticketType == "VIP")
                {
                    sum = tickets * 400;
                    if (sum > 2500 && sum <= 4000)
                    {
                        sum = sum * 0.9;
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                    else if (sum > 4000)
                    {
                        sum = sum * 0.75;
                    }
                    else
                    {
                        if (trophy == "Y")
                        {
                            sum += tickets * 40;
                        }
                    }
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
