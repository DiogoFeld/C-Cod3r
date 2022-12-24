using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void alterarRef(ref int numero)
        {
            numero += 1000;
        }


        public static void alterarOut(out int numero, int multiplicador)
        {
            numero = 0;
            numero += 15;
            numero *= multiplicador;
        }


        public static void Main()
        {
            int a = 3;
            alterarRef(ref a);
            //passa uma referencia que guarda o valor que foi alterado, como uma referencia global
            Console.WriteLine(a);

            alterarOut(out int b,2);
            //out "manda" o numero depois de ser chamado, mas não possui referencia
            Console.WriteLine(b);
        }







    }
}
