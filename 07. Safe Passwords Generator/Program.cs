using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int i = 1;
            char A = '#';
            char B = '@';
            int x = 1;
            int y = 1;
            char A1 = '#';
            char B1 = '@';
            while (i <= max && x <= a)
            {
                if (A > 55)
                {
                    A = '#';
                    Console.Write(A);
                    A++;
                }
                else
                {
                    Console.Write(A);
                    A++;
                }
                if (B > 96)
                {
                    B = '@';
                    Console.Write(B);
                    B++;
                }
                else
                {
                    Console.Write(B);
                    B++;
                }
                while (x <= a)
                {
                    Console.Write(x);
                    while (y <= b)
                    {
                        Console.Write(y);
                        break;
                    }
                    y++;
                    break;
                }
                if (B1 > 96)
                {
                    B1 = '@';
                    Console.Write(B1);
                    B1++;
                }
                else
                {
                    Console.Write(B1);
                    B1++;
                }

                if (A1 > 55)
                {
                    A1 = '#';
                    Console.Write(A1);
                    A1++;
                }
                else
                {
                    Console.Write(A1);
                    A1++;
                }
                i++;
                if (y > b)
                {
                    y = 1;
                    x++;
                }
                Console.Write("|");
            }
        }
    }
}
