using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class operadorTernario
    {
        public void Main()
        {
            double nota = 6.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "reprovado";
            Console.WriteLine("eles esta " + resultado);

        }
    }
}
