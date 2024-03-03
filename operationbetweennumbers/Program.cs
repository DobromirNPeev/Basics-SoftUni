using System;

namespace operationbetweennumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = int.Parse(Console.ReadLine());
            double N2 = int.Parse(Console.ReadLine());
            double result = 0;
            string op= Console.ReadLine();
            switch(op)
            {
                case "+":
                    result = N1 + N2;
                    if(result%2==0)
                    {
                        Console.WriteLine($"{N1} + {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} + {N2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} - {N2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - odd");
                    }
                    break;
                    case "/":
                    result = N1 / N2;
                        if (N2==0)
                        {
                            Console.WriteLine($"Cannot divide { N1} by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} / {N2} = {result,0:f2}");
                        }
                    break;
                case "%":
                    result = N1 % N2;
                        if (N2 == 0)
                        {
                            Console.WriteLine($"Cannot divide { N1} by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} % {N2} = {result}");
                        }
                    break;
            }
        }
    }
}
