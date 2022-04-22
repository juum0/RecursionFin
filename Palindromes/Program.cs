using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string word = Console.ReadLine();
            string cleanWord = "";
            foreach (char c in word)
                if (Char.IsLetter(c) == true)
                    cleanWord = cleanWord + c;
            cleanWord = cleanWord.ToLower();
            if (Palindrome(cleanWord) == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

        }

        static bool Palindrome(string word)
        {
            if (word.Length <= 1)
                return true;
            else if ((!(word.Substring(0, 1) == word.Substring(word.Length - 1, 1))))
                return false;
            else
                return Palindrome(word.Substring(1, word.Length - 2));
            
        }
    }
}
