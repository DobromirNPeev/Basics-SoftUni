using System;

namespace _14._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            for (int num1 = 1; num1 <= n; num1++)
            {
                for (int num2 = 1; num2 <= n; num2++)
                {
                    for (char letter1 = 'a';  letter1<= 96+L; letter1++)
                    {
                        for (char letter2 = 'a'; letter2 <= 96 + L; letter2++)
                        {
                            for (int num3 = 1; num3 <= n; num3++)
                            {
                                if(num3>num1 && num3 > num2)
                                {
                                    Console.Write($"{num1}{num2}{letter1}{letter2}{num3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
