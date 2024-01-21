# Structs

- Sintaxe básica
  - Propriedades, Precisa iniciar com maiúscula
    ```cs
        struct Pessoa
        { 
            public string Nome; 
            public int Idade;   
        }
    ```
  - Método construtor, Precisa ser com inicial maiúscula
    ```cs
        struct Pessoa
        {
            public Pessoa(string nome, int idade) // Convenção para criar variável com inicial minúscula para fins de identificação
            {
                Nome = nome;
                Idade = idade;
            }
        }
    ```
  - Métodos ou funções, Não precisa ser com inicial maiúscula
    ```cs
        struct Moeda
        {
            public Real;
            public int Conversor(int dolar) // Função no qual retorna valor de um tipo específico
            {
                return Real * dolar;
            } 
        }
    ``` 
- Para chamar a estrutura
  - Invocando a struct: **Método Contrutor**
    ```cs
        internal class Program
        {
            private static void Main(string[] args)
            {
                var pessoa = new Pessoa()
                {
                    Console.WriteLine(pessoa.Nome);
                    Console.WriteLine(pessoa.Idade);
                }
            }
        }
    ```
