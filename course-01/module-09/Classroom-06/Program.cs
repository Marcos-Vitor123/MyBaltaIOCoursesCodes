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
            Console.WriteLine(texto.Remove(7, 10));
            Console.WriteLine(texto.Length); // Propriedade
        }
    }
}
