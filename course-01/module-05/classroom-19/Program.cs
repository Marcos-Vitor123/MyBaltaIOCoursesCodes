using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int? inteiro = null;
            Console.WriteLine(inteiro);

            inteiro = 10;
            Console.WriteLine(inteiro);

            inteiro = null;
            Console.WriteLine(inteiro);

            inteiro = 0;
            Console.WriteLine(inteiro);
        }
    }
}
