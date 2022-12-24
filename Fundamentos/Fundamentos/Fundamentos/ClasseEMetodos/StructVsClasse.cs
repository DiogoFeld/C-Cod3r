using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    public struct PontoNewS
    {
        public int x;
        public int y;
    }
    public class PontoNewC
    {
        public int x;
        public int y;
    }


    public class StructVsClasse
    {
        public void Main()
        {
            //struct
            PontoNewS pontoNewS = new PontoNewS()
            {
                x = 1,
                y = 5
            };
            PontoNewS copiaPontoS  = pontoNewS;
            pontoNewS.x = 2;//mudando o valor de X

            Console.WriteLine("original é : {0}", pontoNewS.x);
            Console.WriteLine("copia é : {0}", copiaPontoS.x);
            //Referencia é o valor
            Console.WriteLine("CLASSE");
            //Classe
            PontoNewC pontoNewC = new PontoNewC()
            {
                x = 1,
                y = 5
            };
            PontoNewC copiaPontoC = pontoNewC;
            pontoNewC.x = 2;//mudando o valor de X
            Console.WriteLine("original é : {0}", pontoNewC.x);
            Console.WriteLine("copia é : {0}", copiaPontoC.x);
            //Referencia é a intancia

        }
    }

}