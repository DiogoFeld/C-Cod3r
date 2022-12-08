using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class ReadData
    {
        public void Main()
        {
            Console.WriteLine("qual seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"ola {nome}");

        }
    }
}
