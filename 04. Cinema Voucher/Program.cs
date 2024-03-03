using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            double allSum = 0;
            int movieCount = 0;
            int otherCount = 0;
            while(text!="End")
            {
                if (text.Length > 8)
                {
                    char letter1 = text[0];
                    char letter2 = text[1];
                    int ascii = letter1;
                    int ascii1 = letter2;
                    allSum += ascii + ascii1;
                    if (allSum > voucher) break;
                    movieCount++;
                }
                else
                {
                    char letter1 = text[0];
                    int ascii = letter1;
                    allSum += ascii;
                    if (allSum > voucher) break;
                    otherCount++;
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(movieCount);
            Console.WriteLine(otherCount);
        }
    }
}
