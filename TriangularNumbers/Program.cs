using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine("N: " + i + " T(n): " + Tri(i));
        }

        static int Tri(int n)
        {
            {
                if (n == 1)
                    return n;
                else
                    return n + Tri(n - 1);
            }
        }
    }
}

