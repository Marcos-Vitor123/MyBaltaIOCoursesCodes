using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 100;

            bool entre = (x == 100) && (x != 80);
            Console.WriteLine($"Resultado verdadeiro: \t{entre}");

            entre = (x > 100) && (x < 100);
            Console.WriteLine($"Resultado falso: \t{entre}");

            bool ou = (x == 100) || (x < 100);
            Console.WriteLine($"Resultado verdadeiro: \t{ou}");

            ou = (x > 100) || (x < 100);
            Console.WriteLine($"Resultado falso: \t{ou}");

            bool negacao = !(x < 100);
            Console.WriteLine($"Resultado verdadeiro: \t{negacao}");

            negacao = !(x != 80);
            Console.WriteLine($"Resultado falso: \t{negacao}");   
        }
    }
}