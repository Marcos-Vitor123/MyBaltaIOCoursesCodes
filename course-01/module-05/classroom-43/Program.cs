using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var modelo = new Carro("Ferrari", 1000000.00m);
            var modelo2 = new Carro("Porche", 2000.00m);

            Console.WriteLine($"Modelo: {modelo.Nome}");
            Console.WriteLine($"Valor: {modelo.Valor}\n");

            Console.WriteLine($"Modelo: {modelo2.Nome}");
            Console.WriteLine($"Valor: {modelo2.Valor}");
        }

        struct Carro 
        {
            public string Nome;
            public decimal Valor;

            public Carro(string nome, decimal valor)
            {
                Nome = nome;
                Valor = valor;
            }
        }

    }
}
