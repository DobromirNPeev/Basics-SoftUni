using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int studentsNum = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            if (season == "Winter")
            {
                if (type == "boys")
                {
                    if (studentsNum >= 50)
                    {
                        price = (9.6 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Judo {price:f2} lv.");
                    }
                    else if(studentsNum>=20 && studentsNum < 50)
                    {
                        price = (9.6 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Judo {price:f2} lv.");
                    }
                    else if(studentsNum>=10 && studentsNum < 20)
                    {
                        price = (9.6 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Judo {price:f2} lv.");
                    }
                    else
                    {
                        price = (9.6 * studentsNum) * nights;
                        Console.WriteLine($"Judo {price:f2} lv.");
                    }
                }
                else if (type == "girls")
                {
                    if (studentsNum >= 50)
                    {
                        price = (9.6 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Gymnastics {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (9.6 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Gymnastics {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (9.6 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Gymnastics {price:f2} lv.");
                    }
                    else
                    {
                        price = (9.6 * studentsNum) * nights;
                        Console.WriteLine($"Gymnastics {price:f2} lv.");
                    }
                }
                else if (type == "mixed")
                {
                    if (studentsNum >= 50)
                    {
                        price = (10 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Ski {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (10 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Ski {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (10 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Ski {price:f2} lv.");
                    }
                    else
                    {
                        price = (10 * studentsNum) * nights;
                        Console.WriteLine($"Ski {price:f2} lv.");
                    }
                }
            }
            else if (season == "Spring")
            {
                if (type == "boys")
                {
                    if (studentsNum >= 50)
                    {
                        price = (7.2 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Tennis {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (7.2 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Tennis {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (7.2 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Tennis {price:f2} lv.");
                    }
                    else
                    {
                        price = (7.2 * studentsNum) * nights;
                        Console.WriteLine($"Tennis {price:f2} lv.");
                    }
                }
                else if (type == "girls")
                {
                    if (studentsNum >= 50)
                    {
                        price = (7.2 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Athletics {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (7.2 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Athletics {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (7.2 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Athletics {price:f2} lv.");
                    }
                    else
                    {
                        price = (7.2 * studentsNum) * nights;
                        Console.WriteLine($"Athletics {price:f2} lv.");
                    }
                }
                else if (type == "mixed")
                {
                    if (studentsNum >= 50)
                    {
                        price = (9.50 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Cycling {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (9.50 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Cycling {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (9.5 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Cycling {price:f2} lv.");
                    }
                    else
                    {
                        price = (9.5 * studentsNum) * nights;
                        Console.WriteLine($"Cycling {price:f2} lv.");
                    }
                }
            }
            else if (season == "Summer")
            {
                if (type == "boys")
                {
                    if (studentsNum >= 50)
                    {
                        price = (15 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Football {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (15 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Football {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (15 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Football {price:f2} lv.");
                    }
                    else
                    {
                        price = (15 * studentsNum) * nights;
                        Console.WriteLine($"Football {price:f2} lv.");
                    }
                }
                else if (type == "girls")
                {
                    if (studentsNum >= 50)
                    {
                        price = (15 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Volleyball {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (15 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Volleyball {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (15 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Volleyball {price:f2} lv.");
                    }
                    else
                    {
                        price = (15 * studentsNum) * nights;
                        Console.WriteLine($"Volleyball {price:f2} lv.");
                    }
                }
                else if (type == "mixed")
                {
                    if (studentsNum >= 50)
                    {
                        price = (20 * studentsNum) * nights;
                        price = price * 0.5;
                        Console.WriteLine($"Swimming {price:f2} lv.");
                    }
                    else if (studentsNum >= 20 && studentsNum < 50)
                    {
                        price = (20 * studentsNum) * nights;
                        price = price * 0.85;
                        Console.WriteLine($"Swimming {price:f2} lv.");
                    }
                    else if (studentsNum >= 10 && studentsNum < 20)
                    {
                        price = (20 * studentsNum) * nights;
                        price = price * 0.95;
                        Console.WriteLine($"Swimming {price:f2} lv.");
                    }
                    else
                    {
                        price = (20 * studentsNum) * nights;
                        Console.WriteLine($"Swimming {price:f2} lv.");
                    }
                }
            }
        }
    }
}
