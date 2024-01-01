using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int on = 0;
            int off = 1;

            Console.Write("Digite 0 para ligar ou 1 para desligar: ");
            int active = Convert.ToInt32(Console.ReadLine());

            if(active == on)
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine($"*\t\tBem vindo ao programa!                     *");
                Console.WriteLine("*                                                          *");
                Console.WriteLine("*                                                          *");
                Console.WriteLine("*                                                          *");
                Console.WriteLine("*                                                          *");
                Console.WriteLine("*                                                          *");
                Console.WriteLine("*                                                          *");
                Console.WriteLine("************************************************************");
            } else if (active == off)
            {
                Console.WriteLine("\nPrograma finalizado com sucesso!\n");
            } else
            {
                Console.WriteLine("\nComando inválido!\n");
            } 
            Console.Write("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}