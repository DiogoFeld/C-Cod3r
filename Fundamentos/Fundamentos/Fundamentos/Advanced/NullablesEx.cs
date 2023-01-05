using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Advanced
{
    internal class NullablesEx
    {
        public void Main()
        {
            Nullable<int> num1 = null;
            int? num2 = null;
            Nullable<int> num3 = null;

            if (!num1.HasValue)//negacao
               Console.WriteLine($"variavel nao possue valor {num1}");

            int? valor = num1 ?? 313; //parecido com funcoes ternarias mas nesse caso apenas com dois termos, o ?? checa se é nulo, o seguinte é o padrão
            if (valor.HasValue)
                Console.WriteLine($"variavel possue o valor {valor}");

            bool? bool1 = null;
            bool? resultado = bool1.GetValueOrDefault();
            Console.WriteLine($"bool tem o valor de {bool1}");
            Console.WriteLine($"resultado tem o valor de {resultado}");




        }
    }
}
