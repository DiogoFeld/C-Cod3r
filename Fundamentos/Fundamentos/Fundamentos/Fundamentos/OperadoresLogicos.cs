using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class OperadoresLogicos
    {

        public void Main()
        {
            bool trabalhoTerca = true;
            bool trabalhoQuinta = false;

            var comprou50 = trabalhoTerca && trabalhoQuinta;
            Console.WriteLine($"comprou a tv 50 {comprou50}");


            var comprou30 = trabalhoTerca ^ trabalhoQuinta;
            // '^' é um operador exclusivo - apenas um pode ser verdadeiro 
            Console.WriteLine($"comprou a tv 30 {comprou30}");

            var comprouSorvete = trabalhoTerca || trabalhoQuinta;
            Console.WriteLine($"comprou o sorvete {comprouSorvete}");


        }

    }
}
