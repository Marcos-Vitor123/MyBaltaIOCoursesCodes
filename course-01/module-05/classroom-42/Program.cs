using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Criando uma estrutura
            var product = new Product();

            // Criando e preechendo dados do tipo padrão
            product.Id = 1;
            product.Title = "Mouse Gamer";
            product.Price = 197.23f;

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Title);
            Console.WriteLine(product.Price);
        }

        struct Product
        {
           // Propriedades
           public int Id;
           public string Title;
           public float Price;

           // Métodos 
           public float priceInDolar(float dolar)
           {
                return Price * dolar;
           }
        } 
    }
}
