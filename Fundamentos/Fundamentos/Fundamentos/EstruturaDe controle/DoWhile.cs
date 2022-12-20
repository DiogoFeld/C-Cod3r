using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class DoWhile
    {
        public void Main()
        {
            string entrada;
            bool resultado;

            do
            {
                Console.Write("qual seu nome?");
                entrada = Console.ReadLine();
                Console.Write($"Bem vindo {entrada}");
                Console.Write("quer continuar s/n? ");
                string resposta = Console.ReadLine();
                resultado = resposta.ToLower() == "s";
            }
            while (resultado);
        }


    }
}
