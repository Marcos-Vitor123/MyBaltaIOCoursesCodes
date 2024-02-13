using System;
using System.Threading;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos");
            Console.WriteLine("M - Minutos");
            Console.WriteLine("X - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Tempo finalizado!");
            Thread.Sleep(2500);
        }
    }
}