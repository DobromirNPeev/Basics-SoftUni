using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            string gender = Console.ReadLine();
            double catMonths = 0;
            if(breed== "British Shorthair")
            {
                if (gender == "m")
                {
                    catMonths = (13 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
                else
                {
                    catMonths = (14 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else if(breed == "Siamese")
            {
                if (gender == "m")
                {
                    catMonths = (15 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
                else
                {
                    catMonths = (16 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else if (breed == "Persian")
            {
                if (gender == "m")
                {
                    catMonths = (14 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
                else
                {
                    catMonths = (15 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else if (breed == "Ragdoll")
            {
                if (gender == "m")
                {
                    catMonths = (16 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
                else
                {
                    catMonths = (17 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else if (breed == "American Shorthair")
            {
                if (gender == "m")
                {
                    catMonths = (12 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
                else
                {
                    catMonths = (13 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else if (breed == "Siberian")
            {
                if (gender == "m")
                {
                    catMonths = (11 * 12) / 6;
                    catMonths = Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
                else
                {
                    catMonths = (12 * 12) / 6;
                    catMonths= Math.Floor(catMonths);
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else
            {
                Console.WriteLine($"{breed} is invalid cat!");
            }
        }
    }
}
