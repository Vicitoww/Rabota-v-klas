using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 words"); // napishi ninja banan ili portokal
            Console.Write("Input 1st word:  ");
          string word1=  Console.ReadLine();
            Console.Write("Input 2nd word:  ");
            string word2 = Console.ReadLine();
            Console.Write("Input 3rd word:  ");
            string word3 = Console.ReadLine();
            Console.Write("Which word whould you like:");
            int word = int.Parse(Console.ReadLine());

            if (word == 1)
            {
                Console.WriteLine($"Your word is: {word1} ");
            }
            else if (word == 2)
            {
                Console.WriteLine($"Your word is: {word2}");
            }
            else if (word == 3)
            {
                Console.WriteLine($"Your word is: {word3}");
            }
        }
    }
}
