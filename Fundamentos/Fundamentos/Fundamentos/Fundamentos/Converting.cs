using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class Converting
    {
        public void Main()
        {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;

            double nota = 9.8;
            int notaTruncada = (int)nota;

            Console.WriteLine("Digite um numero");
            string palavraNumero = Console.ReadLine();
            int numero;
            int.TryParse(palavraNumero, out numero);//tente converter, caso de certa, assuma o segundo valor            Console.WriteLine("Digite um numero");
            Console.WriteLine("resultado é:  {0}",numero);

        }   
    
    }
}
