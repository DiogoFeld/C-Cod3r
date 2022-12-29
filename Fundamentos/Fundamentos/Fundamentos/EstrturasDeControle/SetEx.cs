using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstrturasDeControle
{
    internal class SetEx
    {
        public void Main()
        {
            Produto p1 = new Produto("GOT", 45);
            HashSet<Produto> carrinho = new HashSet<Produto>();
            carrinho.Add(p1);

            HashSet<Produto> comboDeProduto = new HashSet<Produto>
            {
                new Produto("camisa",99),
                new Produto("calca",159),
                new Produto("Jeans",80),
                new Produto("sunga",30),
            };
            printList(comboDeProduto);
            comboDeProduto.UnionWith(carrinho);
            printList(comboDeProduto);
            comboDeProduto.Add(p1);
            //duplicados não são adicionados
            comboDeProduto.Add(p1);
            printList(comboDeProduto);




        }

        void printList(HashSet<Produto> lista)
        {
            foreach (Produto p in lista)
            {
                Console.WriteLine("O item {0} vale {1}", p.Nome, p.Preco);

            }
            Console.WriteLine("------------------");
        }







    }
}
