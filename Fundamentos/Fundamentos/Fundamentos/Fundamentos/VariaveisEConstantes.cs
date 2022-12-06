using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class VariaveisEConstantes
    {
        internal void Main()
        {
            area(5);
            
        }

        private void area(int raio)
        {
            const double pi = 3.14;
            double result = pi * raio * raio;

            Console.WriteLine($"Area é {result}");

            byte tByte = byte.MaxValue;//apenas um bity - 8 bits 
            Console.WriteLine($"Total é {tByte}");

            sbyte tSbyte = sbyte.MinValue;//menor valor permitido
            Console.WriteLine($"Total de sbyte é {tSbyte}");

            short tShort = short.MinValue;//bem maior que o sbyte
            Console.WriteLine($"Total  de short é {tShort}");


            int tInt = int.MinValue;
            Console.WriteLine($"O menor valor de int é {tInt}");

            uint tUint = uint.MinValue;//sempre trará o numero positivo 
            Console.WriteLine($"O menor valor de uint é {tUint}");

            decimal tDecimal = decimal.MaxValue;
        }
    }
}
