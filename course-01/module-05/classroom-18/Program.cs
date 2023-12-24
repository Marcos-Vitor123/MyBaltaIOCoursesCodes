using System;

namespace classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           object objeto = 10; // Aqui aceita assim e pode mudar depois para qualquer tipo Exemplo: linha 14
           var variavel = 20; // Só aceita assim
           var texto = "texto"; // Só aceita assim
           int inteiro = 30; // Só aceita assim

           objeto = "texto2"; // Aqui aceita, lembrando que sempre será do tipo object, apesar do seus dados aqui ser string
           //variavel = "dd"; // Não aceita
           //texto = 10; Não aceita
           //inteiro = "ddd"; // Não aceita

           Console.WriteLine($"Objeto: {objeto}\nVariavel: {variavel}\nTexto: {texto}\nInteiro: {inteiro}\n");
        }
    }
}