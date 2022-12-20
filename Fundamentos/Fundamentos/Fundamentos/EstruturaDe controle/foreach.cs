using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class @foreach
    {
        public void Main()
        {
            string palavra = "opa!";
            foreach(char c in palavra)
            {
                Console.WriteLine("ess char equivale a: " + c);
            }



            string[] alunos = new string[] { "Antonio", "bianco", "cirino" };
            foreach(string a in alunos)
            {
                Console.WriteLine($"o aluno é {a}");
            }
        }


    }
}
