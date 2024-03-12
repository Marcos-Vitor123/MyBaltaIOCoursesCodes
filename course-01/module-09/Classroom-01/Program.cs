using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            //id.ToString(); // Convertendo para tipo string

            //id = new Guid("23ac9f8e-8c75-4e50-9b33-476921e98f0d"); // Passagem direta como string 
            if(id == Guid.NewGuid()) // Comparando 2 Guid de diferentes geração
            {
                Console.WriteLine("Guid's Iguais!");
                Console.WriteLine(id); 
            } else
            {
                Console.WriteLine(id);
            }
            //Exibe números em Hash e não se repetem, é raro!
            //Console.WriteLine(id.ToString().Substring(0, 8)); // Exibindo somente a 8 primeiras posições do Hash
        }
    }
}