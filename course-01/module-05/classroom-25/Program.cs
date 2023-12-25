using System;

namespace Program
{
   internal class Program
    {
        private static void Main(string[] args)
        {
            int inteiro = Convert.ToInt32("100");
            string letras = Convert.ToString(100);
            string letras2 = Convert.ToString(100.8);

            Console.WriteLine($"\nValor atual do tipo inteiro para string: {inteiro}");
            Console.WriteLine($"\nValor atual do tipo string para inteiro: {letras}");
            Console.WriteLine($"\nValor atual do tipo string para flutuante: {letras2}\n");
        }
    } 
}
