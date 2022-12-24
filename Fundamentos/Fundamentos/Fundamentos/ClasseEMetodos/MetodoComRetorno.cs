using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{

    class CalculadoraCadeia
    {

        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia limpar()
        {
            memoria = 0;
            return this;
        }

        public void imprimir()
        {
            Console.WriteLine(memoria);
        }
        //elenca o resultado para depois ter um retono
    }


    internal class MetodoComRetorno
    {


    }
}
