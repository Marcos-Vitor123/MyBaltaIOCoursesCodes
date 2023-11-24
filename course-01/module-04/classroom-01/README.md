#  Instalação

- <a href="https://balta.io/blog/dotnet-instalacao-configuracao-e-primeiros-passos">Instalação .NET</a> Nesse artigo do **balta.io** explica o passo a passo da Instalação
- De maneira resumida alguns pontos importantes
    - **Instalção** Ir ao site oficial e clicar em **"Download the .NET SDK"**.
    - `dotnet --version` Verifica qual a versão instalada
    - `dotnet --list-sdks` Verifica todas as versões do sistema
    - No Blog no link acima também fala da Instalação em cada sistema operacional
    - `dotnet new console` Instalará a versão padrão mais recente na pasta do projeto atual
    - `dotnet new console -f netX.X` Instalará versões anteriores ao seu projeto atual
        - `X` Representa o número da versão
    - Caso queira instalar já criando a pasta do projeto, aí é só colocar `-o nomeDaPasta` na frente de `dotnet new console`
        -`dotnet new console -o MeuConsoleApp -f net5.0`
    - **Exemplo**

        ```
            mkdir myapp  
            cd myapp  
            dotnet new console
        ```
    - **Ou**
        ```
            dotnet new console -o myapp
        ```
    - **Criar com versão anterior** - crie um arquivo  `Global.json`

        ```json
            {  
                "sdk": {  
                    "version": "X.X.XXX" // versão preferida
                }  
            }
        ```
    - **Restaurar pacotes**
        ```
            dotnet restore
        ```
    - **Compilar**
        ```
            dotnet build
        ```
    - **Atualizar Certificados** Para **HTTP** local usado em Web
        ```
            dotnet dev-certs https --clean
            dotnet dev-certs https --trust
        ```
    - **Executar**
        ```
            dotnet run
        ```