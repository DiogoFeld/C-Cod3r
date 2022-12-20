using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class While
    {
        public void Main()
        {
            bool keepAlive = true;
            uint max = 5;


            while (keepAlive)
            {
                Console.WriteLine(max);
                max--;

                if (max == 0)
                    keepAlive = false;
            }

        }
    }
}
