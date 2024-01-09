using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyMethod("a");
            var storeMyMethodReturn = MyMethodReturn("aaa", "bbb");
            Console.WriteLine(storeMyMethodReturn);
        }

        private static void MyMethod(string inteiro)
        {
            Console.WriteLine(inteiro);
        }

        private static string MyMethodReturn(string first, string second)
        {
            return first + " " + second;
        }
    }
}