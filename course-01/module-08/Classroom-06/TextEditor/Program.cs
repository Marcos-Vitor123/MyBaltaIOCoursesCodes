using System;
using System.IO;

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
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path)) //Ler ou salvar um arquivo
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC Para sair)");
            Console.WriteLine("------------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                if (Console.ReadKey().Key == ConsoleKey.Enter) // Lógica pessoal: Para pular linha após teclar "Enter"
                    text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);

            // Continuação em breve!
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine(); // Vai receber o caminho na variável "path"

            using(var file = new StreamWriter(path)) // Essa função fecha tudo o que é aberto em .NET
            {
                file.Write(text); // Escrever no arquivo "text"
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}

// StreamWrite - Classe que representa um escritor de fluxo de texto e ele escreve um texto no arquivo apontado em seu parâmetro
