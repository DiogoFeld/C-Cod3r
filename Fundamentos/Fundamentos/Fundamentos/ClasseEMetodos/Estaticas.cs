using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{

    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }

    public class Estaticas
    {
        public void Main()
        {
            var resultado = CalculadoraEstatica.Somar(2, 1);
            Console.WriteLine(resultado);
        }
    }

}
