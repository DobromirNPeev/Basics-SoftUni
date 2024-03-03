using System;

namespace VacationWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int spendCount = 0;
            int count = 0;
            while (tripMoney > money && spendCount<5)
            {
                string poss = Console.ReadLine();
                double ss = double.Parse(Console.ReadLine());
                count++;
                if(money<0)
                {
                    money = 0;
                }
                if (poss == "spend")
                {
                    money -= ss;
                    spendCount++;
                }
                else if(poss=="save")
                {
                    money += ss;
                    spendCount=0;
                }
            }
            if( money>=tripMoney)
            {
                Console.WriteLine($"You saved the money for {count} days.");
            }
            if (spendCount == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(count);
            }
        }
    }
}
