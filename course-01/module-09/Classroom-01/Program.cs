using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var id = Guid.NewGuid();

            Console.WriteLine(id);
        }
    }
}