using System;

namespace toyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacPrice = double.Parse(Console.ReadLine());
            int numPuzz = int.Parse(Console.ReadLine());
            int speakDoll = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int totaltoys = numPuzz + speakDoll + teddyBear + minions + trucks;
            double puzzPrice = 2.60 * numPuzz;
            double dollPrice = 3 * speakDoll;
            double bearPrice = 4.10 * teddyBear;
            double minionsPrice = 8.20 * minions;
            double truckPrice = 2 * trucks;
            double totalPrice = puzzPrice + dollPrice + bearPrice + minionsPrice + truckPrice;
            if(totaltoys>50)
            {
                totalPrice=totalPrice * 0.75;
            }
            totalPrice = totalPrice - totalPrice * 0.1;
            if (totalPrice>=vacPrice)
            {
                double leftMoney= totalPrice - vacPrice;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else if(totalPrice<=vacPrice)
            {
                double leftMoney1 = vacPrice - totalPrice;
                Console.WriteLine($"Not enough money! {leftMoney1:f2} lv needed.");
            }

        }
    }
}
