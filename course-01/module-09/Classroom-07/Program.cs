using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "CSharp é o máximo";
            Console.WriteLine(texto.Replace("CSharp", "C#"));
            Console.WriteLine(texto.Replace("o", "X"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(11, 6);
            Console.WriteLine(resultado);
        }
    }
}
