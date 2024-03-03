using System;

namespace lihva
{
    class Program
    {
        static void Main(string[] args)
        {
            double depsum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double lihv = double.Parse(Console.ReadLine());
            double sum = depsum + period * ((depsum * lihv/100) / 12);
            Console.WriteLine(sum);
        }
    }
}
