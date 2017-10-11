using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=50, pos=4;

            System.Console.WriteLine("Number=" + num);
            System.Console.WriteLine("Position=" + pos);

            /*System.Console.WriteLine("Insert number" );
            num = Convert.ToInt16(System.Console.ReadLine());
            System.Console.WriteLine("\nInsert position");
            pos = Convert.ToInt16(System.Console.ReadLine());*/

            if ((num >> pos) % 2 == 0)
                System.Console.WriteLine("The number {0} in position {1} is 0", num , pos);
            else
                System.Console.WriteLine("The number {0} in position {1} is 1", num, pos);

        }
    }
}
 
