#  Variáveis de ambiente

- Existem vários ambientes para as aplicações
    - Dizer ao .NET qual o ambiente `dotnet run --enviromenmt=$SEU_AMBIENTE`
    - Desenvolvimento
        - `dotnet run --enviromenmt=development`
    - Homologação
    - Produção
        - `dotnet run --enviromenmt=production`
- Cada um tem suas configurações
    - Chave de acesso externo
    - Conexões com bancos de dados

**OBS:** **run** não executa **debug**