using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class breakInUse
    {
        public void Main()
        {
            Random random = new Random();
            int randomNumero = random.Next(1, 20);



            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"o numero da vezé: {i}");

                if (randomNumero == i)
                {
                    Console.WriteLine($"achou!");
                    break; //tira do bloco em questão da repetição
                }
            }
            Console.WriteLine($"Obrigado!");
        }


    }
}
