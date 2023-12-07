using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            short tipoShortPositivo = 00012345;
            short tipoShortNegativo = -00012345;
            ushort tipoUShort = 000012345;

            int tipoIntPositivo = 1234567891;
            int tipoIntNegativo = -1234567891;
            uint tipoUInt = 1234567891;

            long tipoLongPositivo = 1234567891234567891;
            long tipoLongNegativo = -1234567891234567891;
            ulong tipoULong = 12345678912345678912;

            Console.WriteLine($"\nTipo short positivo: {tipoShortPositivo}\nTipo short negativo: {tipoShortNegativo}\nTipo ushort: {tipoUShort}\n");
            Console.WriteLine($"\nTipo int positivo: {tipoIntPositivo}\nTipo int negativo: {tipoIntNegativo}\nTipo uint: {tipoUInt}\n");
            Console.WriteLine($"\nTipo long positivo: {tipoLongPositivo}\nTipo long negativo: {tipoLongNegativo}\nTipo ulong: {tipoULong}\n");
        }
    }
}

