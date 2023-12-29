using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine($"O valor de x é: {x}");

            bool result = x == 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result}");

            result = x != 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result}");

            result = x > 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result}");

            result = x < 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result}");

            result = x >= 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result}");

            result = x <= 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result}");
        }
    }
}