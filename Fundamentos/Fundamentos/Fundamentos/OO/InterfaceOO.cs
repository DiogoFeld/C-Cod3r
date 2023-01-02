using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{

    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }


    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;            
        }
    }


    class Multiplicar : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }


    class Substrair : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }


    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Substrair(),
            new Multiplicar()
        };

        public string executarOperacao(int a, int b)
        {
            string resultado = "";

            foreach(var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)} \r\n";
            }

            return resultado;
        }
    }

    internal class InterfaceOO
    {
        public void Main()
        {
            Calculadora c = new Calculadora();
            Console.WriteLine(c.executarOperacao(2, 4));
        }
    }


}
