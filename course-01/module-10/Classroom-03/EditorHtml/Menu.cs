using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            DrawScreem();
            WriteOptions();
            Console.ReadKey();

            var option = short.Parse(Console.ReadLine());
        }

        public static void DrawScreem()
        {
            Linha();
            Coluna();
            Linha();
        }

        public static void Linha()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Coluna()
        {
            for (int lines = 0; lines <= 12; lines++)
            {
                Console.Write("|");
                
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,1);
            Console.WriteLine("\tEditor Html\t");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("Selecione uma opção!");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,11);
            Console.Write("Opção: ");
        }
    }
}