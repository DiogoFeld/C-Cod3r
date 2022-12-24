using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    internal class Props
    {
        public void Main()
        {
            var carro1 = new CarroOpcional("Luxus", 20000);
            Console.WriteLine(carro1.Nome);
        }

    }

    public class CarroOpcional
    {

        public CarroOpcional(string nome_, int preco_)
        {
            nome = nome_;
            preco = preco_;
        }


        double desconto = 0.1;
        string nome;
        public string Nome//percebe que esta com a letra da frente em "major key"
        {
            get
            {
                return "opcional é " + nome;
            }
            set
            {
                nome = value;
            }
        }

        public int preco { get; set; }
        public int precoCDesconto
        {
            get
            {
                return (int)(preco * desconto - preco);
            }
        }

    }



}
