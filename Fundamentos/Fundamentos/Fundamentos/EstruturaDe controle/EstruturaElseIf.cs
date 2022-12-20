using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class EstruturaElIf
    {
        public void Main()
        {
            Console.Write("digite a nota do aluno ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine(nota);

            if (nota >= 7)
            {
                Console.WriteLine("aluno bonzinho");
            }
        }
    }
}
