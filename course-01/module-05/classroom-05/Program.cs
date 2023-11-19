internal class Program
{
    private static void Main(string[] args)
    {
        int idade = 0; // Recomendado iniciar com 0;
        int idade2 = 25; // Certo - inicia com o valor 25
        var idade3 = 25; // Certo - inicia com o valor 25
        //var idade4; // Errado - não foi inicializada com nenhum valor. Portanto não foi definido o tipo ainda
        Console.WriteLine($"\nVariáveis\n\tIdade: {idade}\n\tIdade2: {idade2}\n\tIdade3: {idade3}\n");
    }
}