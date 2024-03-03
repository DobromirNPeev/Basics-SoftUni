using System;

namespace suppforschool
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPen = int.Parse(Console.ReadLine());
            int numMar = int.Parse(Console.ReadLine());
            int Litre = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());
            double packPen = numPen * 5.80;
            double packMar = numMar * 7.20;
            double Litres = Litre * 1.20;
            double percent = discount / 100;
            Console.WriteLine((packPen + packMar + Litres)-((packPen + packMar + Litres)*percent));
        }
    }
}
