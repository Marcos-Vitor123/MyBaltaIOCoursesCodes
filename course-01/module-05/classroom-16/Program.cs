using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string letra1 = "Soma";
            string letra2 = "Arquivos";
            var arquivo1 = 1; 
            var arquivo2 = 2;
            var TotalArquivos = "3";

            int soma = arquivo1 + arquivo2;  

            Console.WriteLine($"\n{letra1} dos {letra2}: {soma} de {TotalArquivos}\n");       
        }
    }
}