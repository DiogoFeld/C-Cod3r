using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Fundamentos
{
    internal class FormatingNumber
    {
        public void Main()
        {
            double valor = 15.179;
            Console.WriteLine(valor.ToString("C"));//moeda
            Console.WriteLine(valor.ToString("F2"));//deixa a ultima para casa respectiva
            Console.WriteLine(valor.ToString("P"));//porcentagem
            Console.WriteLine(valor.ToString("#.##"));//aredonda para casa respectiva 


            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C",culture));//brasil
            Console.WriteLine(valor.ToString("C",new CultureInfo("en-EN")));//eua

            int inteiroPequeno = 87;
            Console.WriteLine(inteiroPequeno.ToString("D8"));//aumenta a quantidade de "tamanho" da string

        }
    }
}
