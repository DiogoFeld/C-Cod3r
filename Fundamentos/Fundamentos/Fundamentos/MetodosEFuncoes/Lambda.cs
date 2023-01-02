using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.MetodosEFuncoes
{ 
    internal class Lambda
    {
        public void Main()
        {
            Action algoNoConole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConole();

            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
                return rand.Next(1, 7);
            };

            Console.WriteLine($"resultado é {jogarDado()}");


            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatData(4, 5, 1995));


        }
    }





}
