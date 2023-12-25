using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inteiroAlias = 20;
            string stringAlias = "String Alias";

            string exibirInteiroAlias = inteiroAlias.GetType().ToString();
            string exibirStringAlias = stringAlias.GetType().ToString();

            Console.WriteLine($"\nA variável inteiroAlias por debaixo dos panos é do tipo: {exibirInteiroAlias}");
            Console.WriteLine($"A variável stringAlias por debaixo dos panos é do tipo: {exibirStringAlias}\n");
        }
    }
}