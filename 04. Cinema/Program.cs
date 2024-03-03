using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int seats = 0;
            string people = Console.ReadLine();
            while(people!="Movie time!")
            {
                int num = int.Parse(people);
                seats += num;
                if (seats > capacity) break;
                if (num % 3 == 0)
                {
                    sum += (num * 5) - 5;
                }
                else
                {
                    sum += num * 5;
                }
                people = Console.ReadLine();
            }
            if(people=="Movie time!")
            {
                Console.WriteLine($"There are {capacity-seats} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {sum} lv.");
            }
            else if(seats>capacity)
            {
                Console.WriteLine($"The cinema is full.");
                Console.WriteLine($"Cinema income - {sum} lv.");
            }
        }
    }
}
