using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Execoes
{
    //Exception é natural do C#
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class ImparException : Exception
    {
        public ImparException(string? message) : base(message)
        {
        }
    }


    internal class ExecaoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);
            //valor = 3;
            //valor = -4;

            if(valor < 0)
            {
                throw new NegativoException("numero negativo............: (");
            }
            if(valor %2 == 1)
            {
                throw new ImparException("Valor Impar............: (");
            }
            return valor;
        }



        public void Main()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch(NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}
