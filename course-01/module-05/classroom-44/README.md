# Enumeradores
- É um **inteiro** que substitui uma valor que seria usado como inteiro
- Sempre inicia com a letra **E** maiúscula e também o nome do **emumerador** é com inicial ***maiúscula***
- É de mesmo nível da estrutura
- Não criar dentro da estrutura ou algo assim
## Estrutura
```cs
    private static void Main(string[] args)
    {
        var estrutura = Estrutura("primeiro parâmetro", EEstruturaEnumerador.enumerador);

        Console.WriteLine(Estrutura.Propriedade);
        Console.WriteLine(Estrutura.Propriedade2);
        Console.WriteLine((int)Estrutura.Propriedade2);
    }

    struct Estrutura
    {
        public string Propriedade;
        public EEstruturaEnumerador Propriedade2;
        
        string funcao(string propriedade, EEstruturaEnumerador propriedade2)
        {
            Propriedade = propriedade;
            Propriedade2 = propriedade2;
        }
    }

    enum EEstruturaEnumerador
    {
        // Enumeradores
        enumerador = 1;
        enumerador2 = 2;
        enumerador3 = 3
    }
```