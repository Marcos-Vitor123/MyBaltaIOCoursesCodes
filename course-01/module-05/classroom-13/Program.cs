using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float tipoFloat = 11.123456789F;
            double tipoDouble = 22.123456789123456789;
            decimal tipoDecimal = 33.123456789123456789123456789123456789M;

            Console.WriteLine($"\nTipo float: {tipoFloat}\nTipo double: {tipoDouble}\nTipo decimal: {tipoDecimal}\n");
        }
    }
}
