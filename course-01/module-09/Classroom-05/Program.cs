using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "CSharp é o máximo";

            Console.WriteLine(texto.IndexOf("m")); // Exibe a posição do primeiro caracter qualquer escolhido na frase ou array
            Console.WriteLine(texto.LastIndexOf("m")); // Exibe a última posição de um caracter escolhido na frase ou array
            Console.WriteLine(texto.LastIndexOf("C"));
        }
    }
}
