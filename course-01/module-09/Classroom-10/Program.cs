using System;
using System.Text;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = new StringBuilder();

            texto.Append("CSharp é o máximo,");
            texto.Append(" pois ");
            texto.Append("é minha ");
            texto.Append("primeira linguagem");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}
