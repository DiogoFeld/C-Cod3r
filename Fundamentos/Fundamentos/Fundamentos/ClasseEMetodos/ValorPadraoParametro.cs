using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    internal class ValorPadraoParametro
    {
        public void Somar(int a = 0,int b = 0)
        {
            Console.WriteLine("soma é igual a {0}", a + b);
        }



        public void Main()
        {
            Somar(2, 4);
            Somar(3);
            Somar();
            Somar(b:4);
        }


    }
}
