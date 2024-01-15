# Tipos de referência e tipos de valor
##Memória é dividida em 2
- **Heap**
  - **Value Reference**
  - Armazena **dados**
  - Guarda o **endereço** dos dados em uso
  - Local da memória
  - Na criação de uma variável, salva a apenas o **endereço** de **referência**
- **Stack**
  - Armazena **referência** do dados
  - **Value Type** 
    - local da memória(alocado)
    - Acessa dados diretamente(variável)
    - Atribuindo valor de uma variável para outra, é feito uma cópia apenas
## Garbage Collector
  - Limpa endereços não usados
  - Não acessa **Stack**
  - Acessa apenas **Heap**