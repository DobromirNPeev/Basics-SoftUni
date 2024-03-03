using System;

namespace traininglab
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            height = height * 100;
            width = width * 100;
            int deskWidth = (int)(width - 100)/70;
            int deskHeight = (int) height/120;
            Console.WriteLine((deskHeight*deskWidth)-3);
        }
    }
}
