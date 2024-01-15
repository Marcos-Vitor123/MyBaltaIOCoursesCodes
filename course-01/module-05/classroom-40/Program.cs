using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Value Type - Stack

            int x = 100;
            int y = x;

            Console.WriteLine($"L 14: {x}"); // 100
            Console.WriteLine($"L 15: {y}"); // 100

            x = 50;

            Console.WriteLine($"L 19: {x}"); // 50 
            Console.WriteLine($"L 20: {y}"); // 100 - Recebe o valor de x inicial ou seja é independente

            // Value Reference - Heap

            var arr = new string[2];
            arr[0] = "Item1";
            arr[1] = "Item2";
            var arr2 = arr;
            

            Console.WriteLine($"L 29: {arr[0]}"); // Item1
            Console.WriteLine($"L 30: {arr2[0]}"); // Item1

            arr[0] = "Item alterado"; 

            Console.WriteLine($"L 34: {arr[0]}"); // Item alterado
            Console.WriteLine($"L 35: {arr2[0]}"); // Item alterado - Recebe o valor do endereço de referência de arr

            arr[1] = "Item alterado II";

            Console.WriteLine($"L 38: {arr[1]}");
            Console.WriteLine($"L 39: {arr2[1]}");
            }}}