using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{
    class Polimorfismo
    {
        public void Main()
        {
            Feijao ingrediente1 = new Feijao(0.3);            
            Arroz ingrediente2 = new Arroz(0.4);            
            Carne ingrediente3 = new Carne(0.2);            

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80;
            cliente.Comer(ingrediente3);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente1);

            Console.WriteLine($"cliente pesa {cliente.Peso}");
        }
    }

    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }
        public Comida() { }


    }

    public class Feijao : Comida
    {
        public double Peso;

        public Feijao(double peso) : base(peso)
        {

        }
    }
    public class Arroz : Comida
    {
        public double Peso;

        public Arroz(double peso) : base(peso)
        {
        }
    }
    public class Carne : Comida
    {
        public double Peso;

        public Carne(double peso) : base(peso)
        {
        }
    }

    public class Pessoa
    {
        public double Peso;

        /*public void Comer(Feijao comida)
        {
            Peso += comida.Peso;
        }
        public void Comer(Arroz comida)
        {
            Peso += comida.Peso;
        }
        public void Comer(Carne comida)
        {
            Peso += comida.Peso;
        }*/

        //método que acopla todas as heranças
        // apos a classe Comida ter sido criada
        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }

    }


}
