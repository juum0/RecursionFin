using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "encyclopedia";
            int a = 0;
            int z = word.Length;
            Console.WriteLine(word.Length);
            Console.WriteLine(word.Substring(0, 4));
            Console.WriteLine(word.Substring(0, 3));
            Console.WriteLine(word.Substring(a, 1));
            Console.WriteLine(word.Substring(z - 1, 1));
            //for (int n = 0; n < 11; n++)
            // Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
               return n = Fib(n - 2) + Fib(n - 1);
        }

    }
}
