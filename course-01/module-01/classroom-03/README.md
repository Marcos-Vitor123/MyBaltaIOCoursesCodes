#  Alto e baixo nível

- **C#** É uma linguagem de alto nível - Mias próxima do entendimento humano
- **Linguagem Assembly** É uma linguagem de máquina de baixo nível - porém, mais distante do entendimento humano, mais complexa

**Exemplo** Linguagem Assembly

```asm
        global _start
        section .text
    _start: mov rax, 1
        mov rdi, 1
        rsi,message
        mov rdx, 13
        syscall
        mov rax, 60
        xor rdi, rdi
        syscall

        section .data
    message: db     "Hello, Word", 10   
```
**Exemplo** Linguagem C#

```cs
    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(String[] args)
            {
                Console.WriteLine("Hello Word"); // Imprime uma mensagem de sáida no Console ou seja, Imprime Hello Word
            }
        }
    }
```