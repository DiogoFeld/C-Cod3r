using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Execoes
{
    internal class PrimeiraExeceao
    {
        public void Main()
        {
            Conta c = new Conta(500);

            try
            {
                //int a = int.Parse("nao inteiro");
                
                c.Sacar(501);
                Console.WriteLine("Sacado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }
        }
    }




    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }


        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                //throw 'lança' a exeção
                throw new ArgumentException("saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
            }
        }
    }

}
