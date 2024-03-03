using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int valid = 0;
            for(int x = 0; x <= n; x++)
            {
                for (int x1 = 0; x1 <= n; x1++)
                {
                    for (int x2 = 0; x2 <= n; x2++)
                    {
                        if (x + x1 + x2 == n)
                        {
                            valid++;
                        }
                    }
                }
            }
            Console.WriteLine(valid);
        }
    }
}
