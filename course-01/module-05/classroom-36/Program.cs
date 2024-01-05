using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int condicao = 0;

            Console.Write("Digite o limite: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            while(condicao <= limite) // Enquanto a condição for verdadeira
            {
                Console.WriteLine($"{condicao}");
                condicao++;
            } 
            Console.ReadKey();
        }
    }
}