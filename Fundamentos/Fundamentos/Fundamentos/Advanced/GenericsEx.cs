using Fundamentos.ClasseEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Advanced
{
    public class Caixa<T>
    {
        T ValorPrivado;

        public T Coisa { get; set;}
        public Caixa(T coisa,T valorPrivado)
        {            
            Coisa = coisa;
            ValorPrivado = valorPrivado;
        }
        public T metodoGenerico(T valor)//retorna T
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return ValorPrivado;
        }
    }

    //recebe os valores genéricos e aplica nos métodos que recebem o tipo genérico
    class CaixaInt : Caixa<int>
    {
        public CaixaInt(int coisa, int valorPrivado) : base(coisa, valorPrivado)
        {

        }
    }

    internal class GenericsEx
    {
        public void Main()
        {
            Caixa<string> novaClasse = new Caixa<string>("primeiro parametro", "Segundo parametro");
            Console.WriteLine(novaClasse.metodoGenerico("hallo"));


            Caixa<Produto> novaClasseDeClasse = new Caixa<Produto>(new Produto(), new Produto());

        }
    }
}
