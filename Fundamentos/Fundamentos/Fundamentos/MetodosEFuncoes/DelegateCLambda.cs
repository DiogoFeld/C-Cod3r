using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.MetodosEFuncoes
{
    
    internal class DelegateCLambda
    {
        delegate double Operacao(double x, double y);
        public void Main()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;


            Console.WriteLine(sum(3, 4));
            Console.WriteLine(sub(3, 4));
            Console.WriteLine(multi(3, 4));

        }
    }
}
