using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=300,b=7, temp;

            System.Console.WriteLine("The numbers before swap");
            System.Console.WriteLine("a=" + a);
            System.Console.WriteLine("b=" + b);

            temp = b;
            b = a;
            a = temp;
            System.Console.WriteLine("\nThe numbers after first swap");
            System.Console.WriteLine("a="+a);
            System.Console.WriteLine("b="+ b);

            a = a + b;
            b = a - b;
            a = a - b;

            System.Console.WriteLine("\nThe numbers after second swap");
            System.Console.WriteLine("a=" + a);
            System.Console.WriteLine("b=" + b);
        }
    }
}
