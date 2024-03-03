using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int V = width * height * lenght;
            string text = Console.ReadLine();
            while (text != "Done")
            {
                int num = int.Parse(text);
                V -= num;
                if (V < 0)
                {
                    break;
                }
                text = Console.ReadLine();
            }
            if (V < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(V)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{V} Cubic meters left.");
            }

        }
    }
}
