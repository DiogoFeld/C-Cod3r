using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    internal class Params
    {

        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }



        public void Main()
        {
            Recepcionar("Pedro", "antonio", "lucia", "jose");

        }

    }
}
