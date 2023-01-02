using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{
    internal class ClasseAbstract
    {

        public void Main()
        {
            List<Celular> celulares = new List<Celular>
            {
                new Samsung(),
                new Iphone()
            };

            foreach(Celular c in celulares)
            {
                Console.WriteLine(c.Tocar());
                Console.WriteLine(c.Assistente());                
            }
        }

        //------------------****---------------
        public abstract class Celular
        {
            public abstract string Assistente();
            public string Tocar()
            {
                return "trim trim trim....";
            }
        }


        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return "meu nome é Bixby";
            }

        }
        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "meu nome é Siri";
            }
        }

    }
}
