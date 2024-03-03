using System;

namespace trekkingmania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                double count1=0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            double sum = 0;
                for(int i=1;i<=n;i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if(num<=5)
                {
                    count1+=num;
                }
                else if(num>=6 && num<=12)
                {
                    count2+=num;
                }
                else if (num >= 13 && num <= 25)
                {
                    count3+=num;
                }
                else if (num >= 26 && num <= 40)
                {
                    count4+=num;
                }
                else if (num >=41)
                {
                    count5+=num;
                }
            }
            Console.WriteLine($"{count1/sum*100,0:f2}%");
            Console.WriteLine($"{count2 / sum * 100,0:f2}%");
            Console.WriteLine($"{count3 / sum * 100,0:f2}%");
            Console.WriteLine($"{count4 / sum * 100,0:f2}%");
            Console.WriteLine($"{count5 / sum * 100,0:f2}%");
        }
    }
}
