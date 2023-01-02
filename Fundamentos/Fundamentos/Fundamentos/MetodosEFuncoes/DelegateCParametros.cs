using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.MetodosEFuncoes
{
    internal class DelegateCParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }


        public static string Calculadora(Operacao o, int x, int y)
        {
            var result = o(x, y);
            return "resultado é " + result.ToString();
        }

        public void Main()
        {
            Operacao sub = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(sub, 10, 7));
            Console.WriteLine(Calculadora(Soma, 2, 8));
        }




    }
}
