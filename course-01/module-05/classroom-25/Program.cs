using System;

namespace Program
{
   internal class Program
    {
        private static void Main(string[] args)
        {
            int inteiro = Convert.ToInt32("100");

            Console.WriteLine($"\nInteiro sem conversão: {inteiro}");
            
            string valorTipoConvertido = inteiro.GetType().ToString();

            Console.WriteLine($"\nInteiro convertido: {inteiro}\n");
            Console.WriteLine($"Valor atual do tipo: {valorTipoConvertido}\n");
        }
    } 
}
