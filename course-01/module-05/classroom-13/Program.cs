using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float tipoFloat = 1.234567891F; // 7 dígitos após o ponto
            float tipoFloat2 = 1234567.891F; // Ou 7 dígitos antes do ponto

            double tipoDouble = 1.234567891234567891; // 15 dígitos após o ponto
            double tipoDouble2 = 123456789123456.789; // Ou 15 dígitos antes do ponto  

            decimal tipoDecimal = 1.23456789123456789123456789123456789123M; // // 28 dígitos após o ponto
            decimal tipoDecimal2 = 123456789123456789123456789.123456789123M; // Ou 27 dígitos antes do ponto 

            Console.WriteLine($"\nTipo float: {tipoFloat}\nTipo float2: {tipoFloat2}\n");
            Console.WriteLine($"\nTipo double: {tipoDouble}\nTipo double2: {tipoDouble2}\n");
            Console.WriteLine($"Tipo decimal: {tipoDecimal}\nTipo decimal2: {tipoDecimal2}\n");
        }
    }
}
