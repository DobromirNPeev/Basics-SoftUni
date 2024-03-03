using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
             while (true)
             {
                string text = Console.ReadLine();
                if (text == "End") break;
                double sum = 0;
                    double budget = double.Parse(Console.ReadLine()); ;
                 while (sum < budget)
                 {
                     double money = double.Parse(Console.ReadLine());
                     sum += money;
                 }
                 Console.WriteLine($"Going to {text}!");
            }
        }
    }
}
