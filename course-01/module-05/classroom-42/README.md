# Structs

- Sintaxe básica
  - **Propriedades**, Precisa iniciar com ***maiúscula***
    ```cs
        struct NomeDaEstrutura
        { 
            public string NomeDaVariavel; 
            public int OutraVariavel;   
        }
    ```
  - **Método construtor**, ***Precisa*** ser com inicial ***maiúscula***
    ```cs
        struct NomeDaEstrutura
        {
            public NomeDaEstrutura(string nomeDaVariavel, int OutraVariavel) // Convenção para criar variável com inicial minúscula para fins de identificação
            {
                NomeDaVariavel = nomeDaVariavel;
                OutraVariavel = outraVariavel;
            }
        }
    ```
  - **Métodos** ou **funções**, ***Não precisa*** ser com inicial ***maiúscula***
    ```cs
        struct NomeDaEstrutura
        {
            public NomeDaVariavel;
            public int NomeDaFuncao(int nomeDaVariavel) // Função no qual retorna valor de um tipo específico
            {
                return NomeDaVariavel * nomeDaVariavel; // Realiza uma operação
            } 
        }
    ``` 
- Para chamar a **estrutura**
  - Invocando a struct: **Método Contrutor**
    ```cs
        internal class Program
        {
            private static void Main(string[] args)
            {
                var nomeDaEstrutura = new NomeDaEstrutura()
                {
                    Console.WriteLine(nomeDaEstrutura.nomeDaVariavel);
                    Console.WriteLine(nomeDaEstrutura.OutraVariavel);
                }
            }
        }
    ```
