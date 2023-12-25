internal class Program
{
    private static void Main(string[] args)
    {
        decimal inteiro = decimal.Parse("100"); // Forma correta
        //int inteiro = int.Parse("ABC"); // Forma errada

        Console.WriteLine($"\nForma correta: {inteiro}\n");
    }
}

