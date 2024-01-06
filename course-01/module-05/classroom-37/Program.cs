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

            do 
            {
                Console.WriteLine($"{condicao}");
                condicao++;
            } while(condicao < limite);
            Console.ReadKey();
        }
    }
}
