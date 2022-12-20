using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class Switch
    {
        public void Main()
        {
            Console.WriteLine("Adicione um numero entre 1 e 5");
            int.TryParse(Console.ReadLine(), out int valor);
            switch (valor)
            {
                case 1: case 2://infileirar os cases coloca eles com o mesmo resultado
                    Console.WriteLine("ruim resultado");
                    break;
                case 3:
                    Console.WriteLine("mediano resultado");
                    break;
                case 4:
                    Console.WriteLine("bom resultado");
                    break;
                case 5:
                    Console.WriteLine("Exelente");
                    break;
                default:
                    Console.WriteLine("nota invalida");
                    break;

            }





        }
    }
}
