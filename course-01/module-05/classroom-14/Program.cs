using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool par = true;
            var impar = true; // do tipo "Var" Apenas para fins de estudos

            Random numero = new();
            int sortear = numero.Next(1, 101);
            int divisor = sortear / 2;

            if(sortear % divisor == 0)
            {
                impar = false;
                Console.WriteLine($"\n\tNúmeros sorteados de 1 a 100\n\nO número sorteado é: {sortear}\n\nParidade PAR é: {par}\nParidade IMPAR é: {impar}\n");
            } else
            {
                par = false;
                Console.WriteLine($"\n\tNúmeros sorteados de 1 a 100\n\nO número sorteado é: {sortear}\n\nParidade PAR é: {par}\nParidade IMPAR é: {impar}\n");
            }
        }
    }
}