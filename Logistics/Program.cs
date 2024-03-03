using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double price = 0;
            int countMicrobus = 0;
            int countTruck = 0;
            int countTrain = 0;
            double sum = 0;
            for(int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= 3)
                {
                    price += num * 200;
                    countMicrobus+=num;
                    sum += num;
                }
                else if(num>=4 && num <= 11)
                {
                    price += num * 175;
                    countTruck+=num;
                    sum += num;
                }
                else if (num >= 12)
                {
                    price += 120 * num;
                    countTrain+=num;
                    sum += num;
                }
            }
            double microbus = countMicrobus / sum * 100;
            double truck = countTruck / sum * 100;
            double train = countTrain / sum * 100;
            Console.WriteLine($"{price/sum:f2}");
            Console.WriteLine($"{microbus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
