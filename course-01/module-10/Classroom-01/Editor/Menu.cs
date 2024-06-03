using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 1600;
            Console.WindowWidth = 900;

            Console.WriteLine
            (@"
                ********************************
                *                              *
                *    Teste linha 1             *
                *    teste linha 2             *  
                *    teste linha 3             *
                *    e assim por diante...     *
                *                              *    
                ********************************
                
            ");
            
            Console.ReadKey();
        }
    }
}