using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{
    class ContrutorThis
    {
        public void Main()
        {
            Cachorro cachorro = new Cachorro("spike", 0.84);
            Cachorro cachorro2 = new Cachorro("cleber");

            Console.WriteLine(cachorro);
            Console.WriteLine(cachorro2);
        }
    }




    public class Animal
    {
        public Animal(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }


    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine("o nome é {0}", nome);
        }
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }




}
