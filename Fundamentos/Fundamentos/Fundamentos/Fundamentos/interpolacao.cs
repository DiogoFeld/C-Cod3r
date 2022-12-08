using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class interpolacao
    {
        public void Main()
        {
            string nome = "noteBook Gamer";
            string marca = "dell";
            double preco = 5200.00;


            Console.WriteLine("O " + nome + " da marca " + marca +
                " custa " + preco + " reais.");

            Console.WriteLine("O {0} da marca {1} custa {2} reais.",nome,marca,preco);

            Console.WriteLine($"O {nome} da marca {marca} custa {preco} reais.");



        }
    }
}
