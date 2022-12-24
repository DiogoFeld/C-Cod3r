using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{

    class Carro
    {
        public string modelo;
        public string placa;
        public int ano;


        public Carro(string modelo, string placa, int ano)
        {
            this.modelo = modelo;
            this.placa = placa;
            this.ano = ano;
        }
    }

    internal class Contrutores
    {
        Carro carro = new Carro("fiesta", "4512AB", 2016);
    }
}
