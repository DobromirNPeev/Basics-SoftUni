using System;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           for (int i = 1; i <= n % 10; i++)
            {
                for (int j = 1; j <= (n % 100) / 10; j++)
                {
                    for (int k = 1; k <= n / 100; k++)
                    {
                        int sum = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {sum};");
                    }
                }
            }
        }
    }
}
