// Aula 22 - Conversão implícita

internal class Program
{
    private static void Main(string[] args)
    {
        float valor = 25.8F;
        Console.WriteLine($"\nVariável valor do (tipo float): {valor}\n");

        int outro = 25;
        Console.WriteLine($"\nVariável outro do (tipo int): {outro}\n");

        valor = outro; // Conversão implícita
        Console.WriteLine($"\nConversão implícita da variável valor do (tipo float) para o (tipo int): {valor}\n");

    }
}

        //outro = valor; // Conversão não aceita
        //Console.WriteLine($"\nConversão implícita da variável valor do (tipo float) p/ o (tipo int): {outro}\n");

        /*************************************

        SAÍDA CONSOLE - Conversão não aceita

        C:\GitHub\my-balta-io-courses-codes\module-05\classroom-22\Program.cs(16,17): error CS0266: Não é possível converter implicitamente tipo "float" em "int". Existe 
        uma conversão explícita (há uma conversão ausente?) [C:\GitHub\my-balta-io-courses-codes\module-05\classroom-22\classroom-22.csproj]

        Ocorreu uma falha no build. Corrija os erros de build e execute novamente.
        
        ***************************************/