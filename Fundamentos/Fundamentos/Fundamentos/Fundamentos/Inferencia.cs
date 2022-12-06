using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class Inferencia
    {
        public void Main()
        {
            var nome = "leonardo";
            nome = "leandro";
            //nome = 123;//NAO pega um outro tipo de variavel do que a original.
            //nao é JS
            Console.WriteLine(nome);
        }

    }
}
