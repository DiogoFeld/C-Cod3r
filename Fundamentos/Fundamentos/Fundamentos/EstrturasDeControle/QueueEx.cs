using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstrturasDeControle
{
    internal class QueueEx
    {
        public void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("caminhao");
            queue.Enqueue("carro");
            queue.Enqueue("moto");


            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count());
            printList(queue);


            queue.Dequeue();
            Console.WriteLine(queue.Count());

            printList(queue);
            Console.WriteLine(queue.Contains("moto"));

        }

        void printList(Queue<string> lista)
        {
            foreach (string p in lista)
            {
                Console.WriteLine("o veiculo é um {0}",p);

            }
            Console.WriteLine("------------------");
        }
    }
}
