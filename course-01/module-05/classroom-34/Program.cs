using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write($"Digite valores de 0 a 9: ");
            int value = Convert.ToInt32(Console.ReadLine());

            switch(value)
            {
                case 0: Console.WriteLine($"O valor é {value}"); break;
                case 1: Console.WriteLine($"O valor é {value}"); break;
                case 2: Console.WriteLine($"O valor é {value}"); break;
                case 3: Console.WriteLine($"O valor é {value}"); break;
                case 4: Console.WriteLine($"O valor é {value}"); break;
                case 5: Console.WriteLine($"O valor é {value}"); break;
                case 6: Console.WriteLine($"O valor é {value}"); break;
                case 7: Console.WriteLine($"O valor é {value}"); break;
                case 8: Console.WriteLine($"O valor é {value}"); break;
                case 9: Console.WriteLine($"O valor é {value}"); break;
                default: Console.WriteLine($"Valor inválido!"); break;
            }
        }
    }
}