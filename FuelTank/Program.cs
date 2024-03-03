using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int litres = int.Parse(Console.ReadLine());
            if (fuelType=="Gas" || fuelType=="Diesel" || fuelType=="Gasoline")
            {
                if (litres >= 25)
                {

                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
