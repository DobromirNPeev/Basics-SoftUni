using System;

namespace architect
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {a * 3} hours to complete {a} project/s.");
         
        }
    }
}
