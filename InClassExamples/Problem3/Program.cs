using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("please enter a character");
            string character = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == character[0])
                {
                    counter++;
                }
            }
            Console.WriteLine($"there are {counter} {character}'s in {sentence}");

            Console.WriteLine("Please enter a word. >>");
            string word = Console.ReadLine();
            string reverse = ReverseWord(word);
            Console.WriteLine(reverse);

            if (word == reverse)
            {
                Console.WriteLine("Palindrome!");
            }

            Console.WriteLine("please enter a number >>");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a number >>");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Numbers(num1, num2);

            Console.ReadKey();
        }
        static string ReverseWord(string word)
        {
            string reverseword = "";
            for (int i = word.Length - 1; i > -1; i--)
            {
                reverseword = reverseword + word[i];
            }
            return reverseword;
        }
        static void Numbers(int num1, int num2)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
