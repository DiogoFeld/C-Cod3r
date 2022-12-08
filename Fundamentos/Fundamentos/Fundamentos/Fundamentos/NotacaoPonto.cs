using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class NotacaoPonto
    {
        public void Main()
        {
            string saudacao = "ola".ToUpper().Insert(3, " word").Replace("word", "mundo");
            Console.WriteLine(saudacao);
        }
    }
}
