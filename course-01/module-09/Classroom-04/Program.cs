using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "C# é a minha linguagem de programação preferida!";
            var texto2 = "C# é a minha linguagem de programação preferida!";
            var texto3 = "C# é a minha linguagem de programação preferida!";
            var testeObjeto = 33;
            bool compararObjeto;

            texto.Equals(texto);
            texto.Equals(texto2);
            texto.Equals(texto3);
            compararObjeto = testeObjeto.Equals(testeObjeto); 

            Console.WriteLine(texto.Equals("C# é a minha linguagem de programação preferida!"));
            Console.WriteLine(texto2.Equals("c# é a minha linguagem de programação preferida!"));
            Console.WriteLine(texto3.Equals("c# é a minha linguagem de programação preferida!", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(compararObjeto);
        }
    }
}