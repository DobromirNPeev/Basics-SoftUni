using System;

namespace _06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double sum = 0;
            double max = int.MinValue;
            string strongest = "";
            while(text!= "End of words")
            {
                for(int i = 0; i < text.Length; i++)
                {
                    char letter = text[i];
                    int ascii = letter;
                    sum += ascii;
                }
                if (text[0] == 'a' || text[0] == 'e' || text[0] == 'i' || text[0] == 'o' || text[0] == 'u' || text[0] == 'y' || text[0] == 'A' || text[0] == 'E' || text[0] == 'I' || text[0] == 'O' || text[0] == 'U' || text[0] == 'Y')
                {
                    sum = sum * text.Length;
                }
                else
                {
                    sum = Math.Floor(sum / text.Length);
                }
                if (sum > max)
                {
                    max=sum;
                    strongest = text;
                }
                text = Console.ReadLine();
                sum = 0;
            }
            Console.WriteLine($"The most powerful word is {strongest} - {max}");
        }
    }
}
