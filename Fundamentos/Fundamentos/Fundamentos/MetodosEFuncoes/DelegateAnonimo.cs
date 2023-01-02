using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.MetodosEFuncoes
{
    internal class DelegateAnonimo
    {
        delegate string SOperacao(string s);

        public void Main()
        {
            SOperacao Inverter = delegate (string s)
            {
                char[] arrayC = s.ToCharArray();
                Array.Reverse(arrayC);
                return new string(arrayC);
            };

            Console.Write(Inverter("Ananas"));

        }



    }
}
