using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaDe_controle
{
    internal class EstruturaIf
    {
        public void Main()
        {
            int notaCorte = 7;
            Console.WriteLine("insira sua nota");
            Double.TryParse(Console.ReadLine(), out double nota);
            if (nota < notaCorte && nota > 4)
            {
                Console.WriteLine("recuperação");
            }
            else if (nota >= notaCorte)
                Console.Write("Aprovado");
            else if (nota >= 9)
                Console.Write(" e com honras");
            else
                Console.WriteLine("Reprovado");//nunca chegara



        }
    }
}
