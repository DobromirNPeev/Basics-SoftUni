using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int value = 0;
            int value1 = 0;
            int diff= 0;
            for(int i = 1; i <= n; i++)
            {
                if (count%2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    int num1 = int.Parse(Console.ReadLine());
                    value = num + num1;
                }
                else
                {
                    int num2 = int.Parse(Console.ReadLine());
                    int num3 = int.Parse(Console.ReadLine());
                    value1 = num2 + num3;
                }
                if (value > value1)
                {
                    diff = value - value1;
                }
                else
                {
                    diff = value1 - value;
                }
                count++;
            }
            if (value == value1 || n==1)
            {
                Console.WriteLine($"Yes, value={value}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
