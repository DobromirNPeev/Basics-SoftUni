using System;

namespace smartlily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toy = 0;
            int money = 0;
            int sumMoney = 0;
            int brotherMoney = 0;
            for(int i=1;i<=age;i++)
            {
                if(i%2==0)
                {
                    money += 10;
                    sumMoney += money;
                    brotherMoney++;
                }
                else if(i%2==1 || i==1)
                {
                    toy++;
                }
            }
            toyPrice = toyPrice * toy;
            sumMoney = sumMoney - brotherMoney;
            if(toyPrice+sumMoney>=laundryPrice)
            {
                double N = toyPrice + sumMoney - laundryPrice;
                Console.WriteLine($"Yes! {N,0:f2}");
            }
            else if(toyPrice+sumMoney<laundryPrice)
            {
                double M = laundryPrice - (toyPrice + sumMoney);
                Console.WriteLine($"No! {M,0:f2}");
            }

        }
    }
}
