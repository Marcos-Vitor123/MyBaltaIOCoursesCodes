using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var modelo = new Carro("Ferrari", "Vermelho", 1000000.00m);
            var modelo2 = new Carro("Porche", "Azul", 200000.00m);

            Console.WriteLine($"Modelo: {modelo.Nome}");
            Console.WriteLine($"Cor: {modelo.Cor}");
            Console.WriteLine($"Valor: {modelo.Valor}\n");

            Console.WriteLine($"Modelo: {modelo2.Nome}");
            Console.WriteLine($"Cor: {modelo2.Cor}");
            Console.WriteLine($"Valor: {modelo2.Valor}");
        }

        struct Carro 
        {
            public string Nome, Cor;
            public decimal Valor;

            public Carro(string nome, string cor, decimal valor)
            {
                Nome = nome;
                Cor = cor;
                Valor = valor;
            }
        }

    }
}
