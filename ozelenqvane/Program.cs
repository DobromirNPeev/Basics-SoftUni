using System;

namespace ozelenqvane
{
    class Program
    {
        static void Main(string[] args)
        {
            double mt = double.Parse(Console.ReadLine());
            Console.WriteLine($"The final price is: {(mt*7.61)- ((mt * 7.61)*0.18)} lv.");
            Console.WriteLine($"The discount is: {(mt*7.61)*0.18} lv.");
        }
    }
}
