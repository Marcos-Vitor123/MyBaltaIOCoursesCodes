using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 2 + 2 * 2;
            int y = 2 + (2 * 2);
            int z = (2 + 2) * 2;

            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
            Console.WriteLine($"Z: {z}");
        }
    }
}