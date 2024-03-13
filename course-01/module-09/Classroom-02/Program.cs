using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // CompareTo() => É uma extensão de tipos strings
            Console.WriteLine(texto.CompareTo("testando"));
        }
    }
}