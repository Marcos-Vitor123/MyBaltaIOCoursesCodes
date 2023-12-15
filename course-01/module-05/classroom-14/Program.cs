using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool valor = true;
            var atual = true;

            Random numero = new();
            int sortear = numero.Next(0, 100);

            if(sortear <= 49)
            {
                Console.WriteLine($"\nÉ Verdadeiro se for abaixo de 50 e falso se for acima de 51 até 100 e o atual acompanha o último resultado\n\nO número sorteado é: {sortear}\nPortando o valor é: {valor}\nE o valor atual é: {atual}\n");
            } else
            {
                valor = false;
                atual = false;
                Console.WriteLine($"\nÉ Verdadeiro se for abaixo de 50 e falso se for acima de 51 até 100 e o atual acompanha o último resultado\n\nO número sorteado é: {sortear}\nPortando o valor é: {valor}\nE o valor atual é: {atual}\n");
            }
        }
    }
}