using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString(); // Convertendo para tipo string

            Console.WriteLine(id); //Exibe números em Hash e não se repetem, é raro!
        }
    }
}