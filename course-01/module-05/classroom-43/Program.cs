using System;

namespace Classroom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pessoa = new Pessoa("Marcos", 34);
            var pessoa2 = new Pessoa("Amara", 33);

            Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade}");

            Console.WriteLine($"{pessoa2.Nome}, {pessoa2.Idade}");

        }

        struct Pessoa
        {
            // Propriedades, Precisa iniciar com maiúscula
            public string Nome; 
            public int Idade;            

            //Método construtor, Precisa ser com inicial maiúscula
            public Pessoa(string nome, int idade) // Convenção para criar variável com inicial minúscula para fins de identificação
            {
                Nome = nome;
                Idade = idade;
            }
        }
    }
}
