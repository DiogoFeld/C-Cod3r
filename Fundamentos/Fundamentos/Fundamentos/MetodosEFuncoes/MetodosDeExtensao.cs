using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.MetodosEFuncoes
{

    public static class ExtensoesInteiro
    {
        public static int Soma(this int num,int outroValor)
        {
            return num + outroValor;
        }
        public static int Sub(this int num, int outroValor)
        {
            return num - outroValor;
        }


    }


    internal class MetodosDeExtensao
    {
        public void Main()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(2));
            Console.WriteLine(numero);
            Console.WriteLine(numero.Sub(10));

            Console.WriteLine(2.Soma(2));
        }


    }
}
