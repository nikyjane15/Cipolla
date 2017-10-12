//Compare two numbers and seeing if the are the same
using System;

namespace CompareRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3000000.22313, b = 756.689;
            bool equal = Math.Abs(a - b) < 0.000001;
            if (equal == true)
                System.Console.WriteLine("a equals b \n");
            else
                System.Console.WriteLine("a is different than b \n");
        }
    }
}