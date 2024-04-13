namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "CSharp é o máximo";

            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Insert(9, "mais que ")); // Insere um caracter na posição indicada pelo primeiro parâmetro
            Console.WriteLine(texto.Remove(0, 1));
            Console.WriteLine(texto.Remove(0, 2));
            Console.WriteLine(texto.Remove(0, 3));
            Console.WriteLine(texto.Remove(0, 4));
            Console.WriteLine(texto.Remove(0, 5));
            Console.WriteLine(texto.Remove(0, 6));
            Console.WriteLine(texto.Remove(0, 7));
            Console.WriteLine(texto.Remove(0, 8));
            Console.WriteLine(texto.Remove(0, 9));
            Console.WriteLine(texto.Remove(0, 10));
            Console.WriteLine(texto.Remove(0, 11));
            Console.WriteLine(texto.Remove(0, 12));
            Console.WriteLine(texto.Remove(0, 13));
            Console.WriteLine(texto.Remove(0, 14));
            Console.WriteLine(texto.Remove(0, 15));
            Console.WriteLine(texto.Remove(0, 16));
            Console.WriteLine(texto.Remove(0, 17));
            Console.WriteLine(texto.Length); // Propriedade
        }
    }
}
