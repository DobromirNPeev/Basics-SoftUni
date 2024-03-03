using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = begin; i <= end; i++)
            {
                if(i%2==0)
                {
                    for (int j = begin; j <= end; j++)
                    {
                        for (int k = begin; k <= end; k++)
                        {
                            if ((j + k) % 2 == 0)
                            {
                                for (int p = begin; p <= end; p++)
                                {
                                    if (p%2==1 && i>p)
                                    {
                                        Console.Write($"{i}{j}{k}{p} ");
                                    }
                                }
                            }
                        }
                    }
                }
                else if(i % 2 == 1)
                {
                    for (int j = begin; j <= end; j++)
                    {
                        for (int k = begin; k <= end; k++)
                        {
                            if ((j + k) % 2 == 0)
                            {
                                for (int p = begin; p <= end; p++)
                                {
                                    if (p % 2 == 0 && i > p)
                                    {
                                        Console.Write($"{i}{j}{k}{p} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
