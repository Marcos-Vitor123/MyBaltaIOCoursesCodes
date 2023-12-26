using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inteiro = 48; // recebe zero como padrão, caso não seja definido nenhum valor. Mas, foi declarada com o valor int 48
            Console.WriteLine($"Variável 01: {inteiro}");

            string tipoValorInteiro1 = inteiro.GetType().ToString(); // Aqui é capturado o tipo da variável inteiro atualmente
            Console.WriteLine($"Variável 02: {tipoValorInteiro1}");

            inteiro = int.Parse("200"); // Aqui essa variável de valor int 48 é alterada para o valor int 200, convertido da string 200 com o Parse()
            Console.WriteLine($"Variável 03: {inteiro}");

            string tipoValorInteiro2 = inteiro.GetType().ToString(); // Aqui é capturado o tipo da variável inteiro atualmente
            Console.WriteLine($"Variável 04: {tipoValorInteiro2}");

            float real = 54.6f; // Aqui é declarada a variável real com o valor float de 54.6
            Console.WriteLine($"Variável 05: {real}");

            int inteiroConvertido = inteiro; // Aqui a variável inteiro, permanece atualizado com o seu valor int 200 alterado anteriormente
            Console.WriteLine($"Variável 06: {inteiroConvertido}");

            inteiro = Convert.ToInt32(real); // Aqui a variável inteiro é alterada o valor int 200 para o valor int 55 arredondado do valor float 54.6
            Console.WriteLine($"Variável 07: {inteiro}");

            inteiro = (int)real; // Aqui a variável inteiro de valor int 55 é alterada para o valor int 54 arredondando do float 54.6
            Console.WriteLine($"Variável 08: {inteiro}");

            real = (int)inteiro; // Aqui a variável real é alterada do valor float 54.6 para o valor int 54, também arrendondada
            Console.WriteLine($"Variável 09: {real}");

            string tipoValorReal1 = real.GetType().ToString(); // Aqui é capturado o tipo da variável real atualmente
            Console.WriteLine($"Variável 10: {tipoValorReal1}");

            string valorReal = real.ToString(); // Aqui a variável real é exibida o seu valor no formato string
            Console.WriteLine($"Variável 11: {valorReal}");

            string tipoValorReal2 = real.GetType().ToString(); // Aqui é capturado o tipo da variável real atualmente
            Console.WriteLine($"Variável 12: {tipoValorReal2}");
        }
    }
}