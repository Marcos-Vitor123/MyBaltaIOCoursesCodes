# Conversão implícita

- Conversão de **dados** entre 2 tipos, desde em que eles sejam compatíveis, do contrário, não aceita.
- Exemplo da forma que **aceita**:
  ```cs
    float valor = 25.8F;
    int outro = 25;

    valor = outro; // Conversão implícita
  ```

- Exemplo da forma que **não aceita**:
  ```cs
    float valor = 25.8F;
    int outro = 25;

    outro = valor; // O valor 25.8, não cabe dentro de 25
  ```
- [**Tabela numérica com os tipos compatíveis**](https://learn.microsoft.com/pt-PT/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions)
- [**Mais detalhes sobre conversões**](https://learn.microsoft.com/pt-PT/dotnet/csharp/programming-guide/types/casting-and-type-conversions)

