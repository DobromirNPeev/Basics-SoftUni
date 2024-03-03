using System;

namespace NumbersFrom1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (true)
            {
                if (num > 10)
                {
                    break;
                }
                Console.WriteLine(num);
                num++;
            }
        }
    }
}
