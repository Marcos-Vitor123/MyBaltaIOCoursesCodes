using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            //id.ToString(); // Convertendo para tipo string

            id = new Guid("23ac9f8e-8c75-4e50-9b33-476921e98f0d"); // Passagem direta como string
            Console.WriteLine(id); //Exibe números em Hash e não se repetem, é raro!
        }
    }
}