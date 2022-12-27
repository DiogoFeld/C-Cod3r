using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstrturasDeControle
{
    public class Produto
    {
        public string Nome;
        public int Preco;

        public Produto(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }


    internal class ListEx
    {
        public void Main()
        {
            Produto p1 = new Produto("GOT", 45);
            List<Produto> carrinho = new List<Produto>();
            carrinho.Add(p1);

            List<Produto> comboDeProduto = new List<Produto>
            {
                new Produto("camisa",99),
                new Produto("calca",159),
                new Produto("Jeans",80),
                new Produto("sunga",30),
            };
            printList(comboDeProduto);
            comboDeProduto.RemoveAt(1);
            printList(comboDeProduto);
            comboDeProduto.Add(p1);
            printList(comboDeProduto);
            Console.WriteLine(comboDeProduto.LastIndexOf(p1));



        }

        void printList(List<Produto> lista)
        {
            foreach (Produto p in lista)
            {
                Console.WriteLine("O item {0} vale {1}", p.Nome, p.Preco);

            }
            Console.WriteLine("------------------");
        }


    }


}
