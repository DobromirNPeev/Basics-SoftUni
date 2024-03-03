using System;

namespace basketballequipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double basShoes = taxPerYear - (taxPerYear * 0.4);
            double basJersey = basShoes - (basShoes * 0.2);
            double ball = basJersey*0.25;
            double access = ball /5;
            Console.WriteLine(taxPerYear+basShoes+basJersey+ball+access);
        }
    }
}
