using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Subtrair();
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado é: {resultado}");

            Console.ReadKey();
        }

        static void Subtrair()
        {
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado é: {resultado}");

            Console.ReadKey();
        }     
    }
}
