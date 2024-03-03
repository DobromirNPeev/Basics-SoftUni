using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            int count = 0;
            double sum = 0;
            double allSum = 0;
            for (int i = 1; i <= clients; i++)
            {
                string decoration = Console.ReadLine();
                while (decoration != "Finish")
                {
                    if (decoration == "basket")
                    {
                        sum += 1.50;
                        count++;
                    }
                    else if(decoration == "wreath")
                    {
                        sum += 3.80;
                        count++;
                    }
                    else if(decoration == "chocolate bunny")
                    {
                        sum += 7;
                        count++;
                    }
                    decoration = Console.ReadLine();
                }
                if (count % 2 == 0)
                {
                    sum = sum * 0.8;
                }
                Console.WriteLine($"You purchased {count} items for {sum:f2} leva.");
                allSum += sum;
                sum = 0;
                count = 0;
            }
            Console.WriteLine($"Average bill per client is: {allSum/clients:f2} leva.");
        }
    }
}
