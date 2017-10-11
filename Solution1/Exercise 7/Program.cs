using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, rest;
            rest = a % 2;
            System.Console.WriteLine("The number is:" + a);
            if (rest == 1)
                System.Console.WriteLine("The number is odd ");
            else
            {
                System.Console.WriteLine("The number is even ");
            }


        }
    }
}

