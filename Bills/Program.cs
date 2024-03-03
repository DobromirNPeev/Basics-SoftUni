using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double elSum = 0;
            double waterSum = 0;
            double internetSum = 0;
            double otherSum = 0;
            double notFinalSum = 0;
            double sum = 0;
            for(int i = 1; i <= months; i++)
            {
                double electricBill = double.Parse(Console.ReadLine());
                elSum += electricBill;
                waterSum += 20;
                internetSum += 15;
                notFinalSum = electricBill + 20 + 15;
                otherSum += notFinalSum + (notFinalSum * 0.2);
            }
            sum += elSum + waterSum + internetSum + otherSum;
            Console.WriteLine($"Electricity: {elSum:f2} lv");
            Console.WriteLine($"Water: {waterSum:f2} lv");
            Console.WriteLine($"Internet: {internetSum:f2} lv");
            Console.WriteLine($"Other: {otherSum:f2} lv");
            Console.WriteLine($"Average: {sum/months:f2} lv");
        }
    }
}
