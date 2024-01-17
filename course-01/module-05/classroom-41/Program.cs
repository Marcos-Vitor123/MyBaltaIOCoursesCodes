using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 10;
            int y = x;

            var arr = new string[2];
            arr[0] = "Letras";
            var arr2 = arr;

            Console.WriteLine($"L 09: {x}");
            Console.WriteLine($"L 10: {y}");
            Console.WriteLine($"L 13: {arr[0]}");
            Console.WriteLine($"L 14: {arr2[0]}");

            x = 30;
            arr[0] = "Alteração";

            Console.WriteLine($"L 21: {x}");
            Console.WriteLine($"L 10: {y}");
            Console.WriteLine($"L 22: {arr[0]}");
            Console.WriteLine($"L 14: {arr2[0]}");
        }
    }
}
