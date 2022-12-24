using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Fundamentos.ClasseEMetodos
{

    public class Produto
    {

        public string Nome;
        public double Preco;
        public static double Deconto = 0.2;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Deconto = desconto;
        }

        public double calcular()
        {
            return Preco - Deconto * Preco;
        }
        public Produto() { }
    }



    class ProdutoEstatico
    {
        public void Main()
        {
            //Produto p1 = new Produto("Borracha", 1, 0.2);
            //Console.WriteLine(p1.calcular());
            ////apos deixar o atributo como sendo static
            Produto p2 = new Produto()
            {
                Nome = "Papel",
                Preco = 2
            };
            Console.WriteLine(p2.calcular());
            Produto p1 = new Produto("Borracha", 1, 0.3);
            Console.WriteLine(p1.calcular());
        }
    }



}
