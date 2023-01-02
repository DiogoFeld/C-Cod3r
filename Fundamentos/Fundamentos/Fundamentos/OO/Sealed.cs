using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{

    sealed class SemFilho
    {
        public double valorFortuna()
        {
            return 14587.12458;
        }
    }

    /*class SouFilho : SemFilho
    {
        //nao permite o filho ser selado
    }*/

    class Vo
    {
        public virtual bool HonrarNome()
        {
            return true;
        }
    }

    class Pai : Vo
    {
        public override sealed bool HonrarNome()
        {
            return false;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNome()
        //{
        //    return true;
        //}

        //    o selead da classe pai nao o deixa sobreescrever
    }

    internal class Sealed
    {
        public void Main()
        {
            SemFilho filho = new SemFilho();
            Console.WriteLine(filho.valorFortuna());

            FilhoRebelde filho2 = new FilhoRebelde();
            Console.WriteLine(filho2.HonrarNome());

        }
    }





}
