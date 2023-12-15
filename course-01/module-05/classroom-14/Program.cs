using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool par = true;
            var impar = true;

            Random numero = new();
            int sortear = numero.Next(1, 101);
            int divisor = sortear / 2;

            if(sortear % divisor == 0)
            {
                impar = false;
                Console.WriteLine($"\nO número sorteado é: {sortear}\n\nParidade PAR é: {par}\nParidade IMPAR é: {impar}\n");
            } else
            {
                par = false;
                Console.WriteLine($"\nO número sorteado é: {sortear}\n\nParidade PAR é: {par}\nParidade IMPAR é: {impar}\n");
            }
        }
    }
}