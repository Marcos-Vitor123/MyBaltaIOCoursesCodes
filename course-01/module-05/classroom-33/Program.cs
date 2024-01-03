using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int active = 0;
            int disable = 1;

            Console.Write("Digite 0 para ativar ou 1 para desativar: ");
            int atack = Convert.ToInt32(Console.ReadLine());

            if(atack == active)
            Console.WriteLine("\nAtivado!\n");
            else if(atack == disable)
            Console.WriteLine("\nDesativado!\n");
            else
            Console.WriteLine("\nOpção inválida!\n");

            Console.ReadKey();
        }
    }
}