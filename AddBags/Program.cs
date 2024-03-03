using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageOver20Price = double.Parse(Console.ReadLine());
            double luggageKg = double.Parse(Console.ReadLine());
            int daysToJourney = int.Parse(Console.ReadLine());
            int numLuggage = int.Parse(Console.ReadLine());

            double luggagePrice = 0;

            if (luggageKg < 10)
            {
                luggagePrice = 0.2 * luggageOver20Price;
            }
            else if(luggageKg>=10 && luggageKg <= 20)
            {
                luggagePrice = 0.5 * luggageOver20Price;
            }
            else if (luggageKg>20)
            {
                luggagePrice = luggageOver20Price;
            }
            if (daysToJourney > 30)
            {
                luggagePrice = luggagePrice * 1.1;
            }
            else if(daysToJourney>=7 && daysToJourney <= 30)
            {
                luggagePrice = luggagePrice * 1.15;
            }
            else if (daysToJourney < 7)
            {
                luggagePrice = luggagePrice * 1.40;
            }
            luggagePrice = luggagePrice * numLuggage;
            Console.WriteLine($"The total price of bags is: {luggagePrice:f2} lv. ");
        }
    }
}
