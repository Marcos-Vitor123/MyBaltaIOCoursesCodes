using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "Eu muito Csharp e dotnet";

            Console.WriteLine(texto.StartsWith("Eu")); // Verifica se inicia-se com a palavra entre aspas
            Console.WriteLine(texto.StartsWith("eu"));
            Console.WriteLine(texto.StartsWith("eu", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("muito"));

            Console.WriteLine(texto.EndsWith("dotnet")); // Verifica se finaliza com a palavra entre aspas
            Console.WriteLine(texto.EndsWith("Dotnet"));
            Console.WriteLine(texto.EndsWith("Dotnet", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("Csharp"));
        }
    }
}