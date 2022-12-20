using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class ContinueInUse
    {
        public void Main()
        {
            int max = 20;

            for (int i = 1; i <= max; i++)
            {
                if(i % 2 == 1)//irá retirar os impares
                {
                    continue;
                }
                Console.WriteLine(i);
                //percebe que ele "pula" os impares
                //o continue é como um passe para o for seguir ao proximo numero da selecao
            }

        }
    }
}
