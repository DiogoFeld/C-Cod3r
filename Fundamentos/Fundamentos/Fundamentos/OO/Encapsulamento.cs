using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{
    class Encapsulamento
    {
        public void Main()
        {

        }
    }


    class SubCelebridade
    {
        //todos
        public string infoPublica = "tenho instagram";
        
        //herança
        protected string corDosOlhos = "Azuis";
                
        /// mesmo projeto        
         internal ulong celular = 95544887711;

        // herança & mesmo projeto
        protected internal string JeitoDeFalar = "nordestino";

        // mesma class ou herança no mesmo projeto 
        private protected string SegredoFamilia = "A tia é sua mãe";

        //private é o padrão
        bool usaPhotoshop = true;

        //dentro da classe vc acessa tudo
        public void MeusAcessos()
        {
            Console.WriteLine(infoPublica);
            Console.WriteLine(corDosOlhos);
            Console.WriteLine(celular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(usaPhotoshop);
        }
    }


}
