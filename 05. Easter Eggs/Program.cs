using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;
            int max = int.MinValue;
            string maxColour = "";
            for (int i = 1; i <= num; i++)
            {
                string colour = Console.ReadLine();
                if (colour == "red")
                {
                    redCount++;
                    if (redCount > max)
                    {
                        max = redCount;
                        maxColour = "red";
                    }
                }
                else if(colour == "orange")
                {
                    orangeCount++;
                    if (orangeCount > max)
                    {
                        max = orangeCount;
                        maxColour = "orange";
                    }
                }
                else if(colour == "green")
                {
                    greenCount++;
                    if (greenCount > max)
                    {
                        max = greenCount;
                        maxColour = "green";
                    }
                }
                else if(colour == "blue")
                {
                    blueCount++;
                    if (blueCount > max)
                    {
                        max = blueCount;
                        maxColour = "blue";
                    }
                }
            }
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {max} -> {maxColour}"
);
        }
    }
}
