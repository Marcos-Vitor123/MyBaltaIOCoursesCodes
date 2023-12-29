using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine($"O valor de x é: {x}");

            bool result1 = x == 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result1}");

            bool result2 = x != 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result2}");

            bool result3 = x > 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result3}");

            bool result4 = x < 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result4}");

            bool result5 = x >= 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result5}");

            bool result6 = x <= 0;
            Console.WriteLine($"O valor de x é: {x}, portanto o valor de comparação é: {result6}");
        }
    }
}