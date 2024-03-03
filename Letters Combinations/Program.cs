using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());
            int count = 0;
            for(char i = begin; i <= end; i++)
            {
                if (i == miss)
                {
                    continue;
                }
                else
                {
                    for (char j = begin; j <= end; j++)
                    {
                        if (j == miss)
                        {
                            continue;
                        }
                        else
                        {
                            for (char k = begin; k <= end; k++)
                            {
                                if (k == miss)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.Write($"{i}{j}{k} ");
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
