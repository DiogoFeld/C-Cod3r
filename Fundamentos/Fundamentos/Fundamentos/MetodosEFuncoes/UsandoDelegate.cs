using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.MetodosEFuncoes
{
    internal class UsandoDelegate
    {
        public void Main()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine("o resultado é : " + op1(4,2));
            ImprimirSoma op2 = MeuImprimirSoma;
            op2(4, 2);
        }



        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);           
        }

        



    }
}
