﻿using System;

namespace workinghours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if(day=="Monday" || day=="Thursday" || day=="Tuesday" || day=="Wednesday" || day=="Friday" || day=="Saturday")
            {
                if (hour>=10 && hour<=18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else if (day=="Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}
