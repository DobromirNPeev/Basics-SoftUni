using System;

namespace Programming_Basics_Online_Exam___28_and_29_March_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double uana = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            int lev = bitcoin * 1168;
            double dollar = uana * 0.15*1.76;
            double sum = (lev + dollar)/1.95;
            sum -= comission / 100 * sum;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
