using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string packageType = Console.ReadLine();
            string VIPCard = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double sum = 0;
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (town == "Bansko")
            {
                if (packageType == "withEquipment")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            sum = sum * 0.9;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            sum = sum * 0.9;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else if (packageType == "noEquipment")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 80;
                            sum = sum * 0.95;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 80;
                            sum = sum * 0.95;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 80;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 80;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (town == "Borovets")
            {
                if (packageType == "withEquipment")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            sum = sum * 0.9;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            sum = sum * 0.9;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else if (packageType == "noEquipment")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 80;
                            sum = sum * 0.95;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 80;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                            sum = sum * 0.95;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 80;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 80;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (town == "Varna")
            {
                if (packageType == "withBreakfast")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 130;
                            sum = sum * 0.88;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 130;
                            sum = sum * 0.88;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 130;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 130;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else if (packageType == "noBreakfast")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            sum = sum * 0.93;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            sum = sum * 0.93;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (town == "Burgas")
            {
                if (packageType == "withBreakfast")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 130;
                            sum = sum * 0.88;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 130;
                            sum = sum * 0.88;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 130;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 130;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else if (packageType == "noBreakfast")
                {
                    if (VIPCard == "yes")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            sum = sum * 0.93;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            sum = sum * 0.93;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                    else if (VIPCard == "no")
                    {
                        if (days > 7)
                        {
                            sum = (days - 1) * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                        else
                        {
                            sum = days * 100;
                            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
