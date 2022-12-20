using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class operadorUnario
    {
        //operadorUnario -> unico operando !/-/++/--
        public void Main()
        {
            var valorNegativo = -3;
            var numero1 = 4;
            var numero2 = 4;
            var boolean = true;


            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!boolean);
            numero1++;
            Console.WriteLine(numero1);
            numero2--;
            Console.WriteLine(numero2);

            //realiza a operação antes da comparação
            Console.WriteLine("resultado de comparação é " + (numero1-- != numero2++));

        }

    }
}
