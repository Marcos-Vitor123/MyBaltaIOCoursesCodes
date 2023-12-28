using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int variavel = 0; // Inicia a variável

            variavel += 1;
            Console.WriteLine($"Variável: {variavel}");

            variavel ++;
            Console.WriteLine($"Variável: {variavel}");

            variavel -= 1;
            Console.WriteLine($"Variável: {variavel}");

            variavel --;
            Console.WriteLine($"Variável: {variavel}");

            variavel *= 1;
            Console.WriteLine($"Variável: {variavel}");

            variavel /= 1;
            Console.WriteLine($"Variável: {variavel}");
        }
    }
}
