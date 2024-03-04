using System;

namespace TextEditor
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
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar no arquivo");
            Console.WriteLine("0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.WriteLine("Abrir");
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC Para sair)");
            Console.WriteLine("------------------------");

            string text = "";
            
            while(Console.ReadKey().Key != ConsoleKey.Escape)

            // Continuação em breve!
        }
    }
}