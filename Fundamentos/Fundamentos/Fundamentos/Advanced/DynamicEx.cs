using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Advanced
{
    internal class DynamicEx
    {
        public void Main()
        {
            dynamic ex = "ex teste";
            ex = 3;//tipagem fraca
            ex++;
            Console.WriteLine(ex);


            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.name = "Ana Henrica";
            aluno.idade = 44;
            aluno.curso = "Matematica";


        }
    }
}
