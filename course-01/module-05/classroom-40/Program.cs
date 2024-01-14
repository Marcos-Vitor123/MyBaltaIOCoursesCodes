using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 100;
            int y = x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 50;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}