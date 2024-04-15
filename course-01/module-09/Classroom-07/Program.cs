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
        }
    }
}
