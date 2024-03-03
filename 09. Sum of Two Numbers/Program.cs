using System;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            bool isFound = false;
            for(int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {
                    if (i + j == magicNum)
                    {
                        count++;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        isFound = true;
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
