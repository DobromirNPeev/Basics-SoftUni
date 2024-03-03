using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            int count = 0;
            while (coins>0)
            {
                if (coins >= 2)
                {
                    coins -= 2.0;
                    coins=Math.Round(coins, 2);
                    count++;
                }
                else if(coins>=1 && coins < 2)
                {
                    coins -= 1.0;
                    coins = Math.Round(coins, 2);
                    count++;
                }
                else if(coins>=0.50 && coins < 1)
                {
                    coins -= 0.50;
                    coins = Math.Round(coins, 2);
                    count++;
                }
                else if(coins>=0.20 && coins<0.50)
                {
                    coins -= 0.20;
                    coins = Math.Round(coins, 2);
                    count++;
                }
                else if(coins>=0.10 && coins < 0.20)
                {
                    coins -= 0.10;
                    coins = Math.Round(coins, 2);
                    count++;
                }
                else if(coins>=0.05 && coins < 0.10)
                {
                    coins -= 0.05;
                    coins = Math.Round(coins, 2);
                    count++;
                }
                else if(coins>=0.02 && coins < 0.05)
                {
                    coins -= 0.02;
                    coins = Math.Round(coins, 2); ;
                    count++;
                }
                else if(coins>=0.01 && coins < 0.02)
                {
                    coins -= 0.01;
                    coins = Math.Round(coins, 2); ;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
