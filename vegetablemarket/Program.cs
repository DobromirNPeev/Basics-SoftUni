using System;

namespace vegetablemarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());
            double sumVeg = vegPrice * kgVeg;
            double sumFruit = fruitPrice * kgFruit;
            Console.WriteLine($"{(sumFruit+sumVeg)/1.94:f2}");
        }
    }
}
