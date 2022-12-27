using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstrturasDeControle
{
    internal class ArrayEx
    {
        public void Main()
        {
            string[] alunos = new string[5];
            alunos[1] = "nathan";

            double[] notas = { 7.5, 4, 10, 6.5, 7.8 };
            double somatorio = 0;

            foreach(double n in notas)
            {
                somatorio += n;
            }

            double result = somatorio / notas.Length;
            Console.WriteLine("resultado é {0}", result);


            //Console.Write(alunos[1]);
            //Console.Write(alunos);

            char[] letras = { 'D', 'I', 'O', 'G', 'O' };
            string final = new string(letras);
            Console.WriteLine(final);
        }



    }
}
