using System;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> pegLeft = new List<int>();
            List<int> pegMid = new List<int>();
            List<int> pegRight = new List<int>();
        }

        
         static Stack<int> LeftPeg()
        {
            List<int> placeholder = new List<int>();
            // return placeholder;
        }

        static void Tower(int numDisks, string sourceTower, string destTower, string exTower)
        {
            if (numDisks == 1)
                Console.WriteLine("move disk n from source to dest");
            else

                numDisks--;
               // move to source from extra 
        } 
    }
}
