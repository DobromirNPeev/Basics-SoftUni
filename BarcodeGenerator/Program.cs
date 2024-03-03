using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int finishNumber = int.Parse(Console.ReadLine());
            int num = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for(int i=startingNumber;i<=finishNumber;i++)
            {
                if ((i / 1000) % 2 == 1)
                {
                    a = i / 1000;
                }
                if ((i / 100) % 2 == 1)
                {
                    b = i / 100;
                }
                if ((i / 10) % 2 == 1)
                {
                    c = i / 10;
                }
                if (i % 2 == 1)
                {
                    a = i ;
                }
                if((i/1000)%2==1 && (i/100)%2==1 && (i/10)%2==1 && i%2==1)
                {
                    Console.WriteLine($"{a}{b}{c}{d}");
                }
            }
        }
    }
}
