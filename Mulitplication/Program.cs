using System;

namespace Mulitplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply(5, 3);
            Console.WriteLine("Multiply");
            for (int n = 1; n <= 10; n++)
                Console.WriteLine(String.Format("5 * {0,2} is {1,2}", n, Multiply(5, n)));
            Console.WriteLine();

            Console.WriteLine("Now for some real fun!");
            Console.WriteLine(String.Format("5 * {0,2} is {1,2}", 0, Multiply(5, 0)));

        }

        // 3 * 1 = 3
        // 3 * 2 = 3 + 3
        // 3 * 3 = 3 + (3 + 3) or 3 + 3 *2
        static int Multiply(int x, int y)
        {
            // every recursive function has a base case - the condition that causes it to stop
            if (y == 1)
                return x;
            // when it's not the base case the function calls itself with a parameter value that approaches the base case
            else
                return x + Multiply(x, y - 1);
        }
    }
}
