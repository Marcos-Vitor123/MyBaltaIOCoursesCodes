using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // CompareTo() => É uma extensão de tipos strings para comparação de 2 string totalmente iguais
            Console.WriteLine(texto.CompareTo("testando"));

            var texto2 = "Eu gosto de Csharp";
            Console.WriteLine(texto2.Contains("Csharp")); // Contains() => Método para comparar uma string inteira ou parte dela
            Console.WriteLine(texto2.Contains("eu"));
            Console.WriteLine(texto2.Contains("eu", StringComparison.OrdinalIgnoreCase));
        }
    }
}