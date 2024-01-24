using System;

namespace Classroom 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var estrutura = new Estrutura("primeiro parâmetro", EEstruturaEnumerador.enumerador);
            var estrutura2 = new Estrutura("primeiro parâmetro", EEstruturaEnumerador.enumerador2);

            Console.WriteLine(estrutura.Propriedade);
            Console.WriteLine(estrutura.Propriedade2);
            Console.WriteLine((int)estrutura.Propriedade2);
            Console.WriteLine(estrutura2.Propriedade2);
            Console.WriteLine((int)estrutura2.Propriedade2);
            
        }
        struct Estrutura
        {
            public string Propriedade;
            public EEstruturaEnumerador Propriedade2;
            
            public Estrutura(string propriedade, EEstruturaEnumerador propriedade2)
            {
                Propriedade = propriedade;
                Propriedade2 = propriedade2;
            }
        }

        enum EEstruturaEnumerador
        {
            // Enumeradores
            enumerador = 1,
            enumerador2 = 2,
            enumerador3 = 3
        }
    }
}
