using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSection = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int oddRowsNum = int.Parse(Console.ReadLine());
            int count = 0;
            char seat = 'a';
            for(char i = 'A'; i <= lastSection; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    seat = 'a';
                        if(j==1 || j % 2 == 1)
                        {
                            for (int k = 1; k <= oddRowsNum; k++)
                            {
                                Console.WriteLine($"{i}{j}{seat}");
                                seat++;
                            count++;
                            }
                        }
                        else if (j % 2 == 0)
                        {
                            for (int k = 1; k <= oddRowsNum+2; k++)
                            {
                            Console.WriteLine($"{i}{j}{seat}");
                            seat++;
                            count++;
                            }
                        }
                }
                rows++;
            }
            Console.WriteLine(count);
        }
    }
}
