# Constantes

- Inalteráveis
- Valor obrigatório
- Inutilizáveis com `var`
- Declaradas com a palavra `const` antes do `tipo`
- Características por determinada convenção: Todas as letras em maíscula e se preciso usar underline `_` 
    ```cs
        const int NUMERO_INTEIRO = 0;
    ```
- **Exemplo Código**

    ```cs
        internal class Program
        {
            private static void Main(string[] args)
            {
                const int IDADE_MINIMA = 0; // Correto - Recomendado iniciar com zero
                const int IDADE_MINIMA2 = 25; // Correto - Inicia com valor 25
                //const var IDADE_MINIMA3 = 25; // Errado - Não funciona com var
                //const var IDADE_MINIMA4; // Errado

                Console.WriteLine($"\n\t\tConstantes\n\n\tIDADE_MINIMA: {IDADE_MINIMA}\n\tIDADE_MINIMA2: {IDADE_MINIMA2}\n");
            }
        }
    ```

- **Saída Console**

    ```
                        Constantes

        IDADE_MINIMA: 0
        IDADE_MINIMA2: 25

    ```
