using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfCoffee = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numOfDrinks = int.Parse(Console.ReadLine());
            double sum = 0;
            if (typeOfCoffee == "Espresso")
            {
                if (sugar == "Without")
                {
                    sum = numOfDrinks * 0.9;
                    sum = sum * 0.65;
                    if (numOfDrinks >= 5)
                    {
                        sum = sum * 0.75;
                    }
                    if (sum >15)
                    {
                        sum = sum * 0.8;
                    }
                }
                else if (sugar == "Normal")
                {
                    sum = numOfDrinks * 1;
                    if (numOfDrinks >= 5)
                    {
                        sum = sum * 0.75;
                    }
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
                else if (sugar == "Extra")
                {
                    sum = numOfDrinks * 1.20;
                    if (numOfDrinks >= 5)
                    {
                        sum = sum * 0.75;
                    }
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
            }
            else if (typeOfCoffee == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    sum = numOfDrinks * 1;
                    sum = sum * 0.65;
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
                else if (sugar == "Normal")
                {
                    sum = numOfDrinks * 1.2;
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
                else if (sugar == "Extra")
                {
                    sum = numOfDrinks * 1.60;
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
            }
            else if (typeOfCoffee == "Tea")
            {
                if (sugar == "Without")
                {
                    sum = numOfDrinks * 0.5;
                    sum = sum * 0.65;
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
                else if (sugar == "Normal")
                {
                    sum = numOfDrinks * 0.6;
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
                else if (sugar == "Extra")
                {
                    sum = numOfDrinks *0.7;
                    if (sum > 15)
                    {
                        sum = sum * 0.8;
                    }
                }
            }
            Console.WriteLine($"You bought {numOfDrinks} cups of {typeOfCoffee} for {sum:f2} lv.");
        }
    }
}
