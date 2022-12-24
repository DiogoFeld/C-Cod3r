using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    internal class ParamNomeados
    {

        public void ListaParametros(string nome, string sobrenome)
        {
            Console.WriteLine("Meu nome é {0} {1}", nome, sobrenome);
        }




        public void Main()
        {
            ListaParametros(sobrenome: "Da silva", nome: "José");
        }


    }
}
