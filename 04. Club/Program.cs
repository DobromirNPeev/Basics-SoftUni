using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());
            string text = "";
            double sum = 0;
            while(sum<profit)
            {
                text = Console.ReadLine();
                if (text == "Party!") break;
                int num = int.Parse(Console.ReadLine());
                double price = text.Length * num;
                if (price % 2 == 1)
                {
                    price = price * 0.75;
                    sum += price;
                }
                else
                {
                    sum += price;
                }
            }
            if (text == "Party!")
            {
                Console.WriteLine($"We need {profit-sum:f2} leva more.");
            }
            else if (sum >= profit)
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {sum:f2} leva.");
        }
    }
}
