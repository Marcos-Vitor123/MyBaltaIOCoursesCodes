using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine($"O valor inicializado de x é: {x}\n");

            Console.WriteLine($"O valor de comparação de x é: {x == 0}");
            Console.WriteLine($"O valor de comparação de x é: {x != 0}");
            Console.WriteLine($"O valor de comparação de x é: {x > 0}");
            Console.WriteLine($"O valor de comparação de x é: {x < 0}");
            Console.WriteLine($"O valor de comparação de x é: {x >= 0}");
            Console.WriteLine($"O valor de comparação de x é: {x <= 0}");
        }
    }
}