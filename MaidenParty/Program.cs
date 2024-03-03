using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRose = int.Parse(Console.ReadLine());
            int keyChain = int.Parse(Console.ReadLine());
            int cartoon = int.Parse(Console.ReadLine());
            int luckyPrice = int.Parse(Console.ReadLine());
            int sum = loveMessages + waxRose + keyChain + cartoon + luckyPrice;
            double allSum= loveMessages*0.6 + waxRose*7.2 + keyChain*3.6 + cartoon*18.2 + luckyPrice*22;
            if (sum>=25)
            {
                allSum = allSum * 0.65;
            }
            allSum = allSum * 0.9;
            if (allSum >= price)
            {
                Console.WriteLine($"Yes! {allSum-price:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {price-allSum:f2} lv needed.");
            }
        }
    }
}
