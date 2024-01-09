using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string showMyMethod = MyMethod("C#", "é", 10, true);
            Console.WriteLine(showMyMethod);
            MyMethodVoid();
        }

        private static string MyMethod(string first, string second, int whole = 0, bool boolean = false)
        {
            return $"{first} {second} {whole.ToString()} {boolean}";
        }

        private static void MyMethodVoid()
        {
            Console.WriteLine("Fim!");
        }
    }
}