using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Criando uma estrutura
            var product = new Product(1, "Mouse Gamer", 128.75f); // Passando valores as variáveis de parâmetros da função

            Console.WriteLine(product.Id); // Exibindo a propriedade Id
            Console.WriteLine(product.Title); // Exibindo a propriedade Title
            Console.WriteLine(product.Price); // Exibindo a propriedade Price
            Console.WriteLine(product.priceInDolar(5.70f)); // Chamando o método ou função e passando valor via parâmetro
        }

        struct Product
        {
            // Propriedades
            public int Id;
            public string Title;
            public float Price;

            // Métodos ou função
           public float priceInDolar(float dolar)
           {
                return Price * dolar;
           }

            // Método Construtor
           public Product(int id, string title, float price)
           {
                Id = id; // Definindo a variável id a propriedade Id via parâmetro da função
                Title = title; // Definindo a variável Title a propriedade title via parâmetro da função
                Price = price; // Definindo a variável price a propriedade Price via parâmetro da função
           }
        } 
    }
}
