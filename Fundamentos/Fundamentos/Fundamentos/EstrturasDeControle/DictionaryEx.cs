using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstrturasDeControle
{
    internal class DictionaryEx
    {
        public void Main()
        {
            Dictionary<int, string> filmesDic = new Dictionary<int, string>();

            filmesDic.Add(2011, "homen aranha");
            filmesDic.Add(2012, "o vingador");
            filmesDic.Add(2013, "2020");
            filmesDic.Add(2016, "vingadores");


            Console.WriteLine(filmesDic.ContainsValue("Requien"));
            Console.WriteLine("removeu? " + filmesDic.Remove(2012));

            filmesDic.TryGetValue(2011, out string filme2011);
            Console.WriteLine("filme de 2011 é {0}", filme2011);

            Console.WriteLine("---------");
            Console.WriteLine("Values");
            foreach (string s in filmesDic.Values)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------");
            Console.WriteLine("Keys");

            foreach (int i  in filmesDic.Keys)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("---------");
            Console.WriteLine("Both");

            foreach (KeyValuePair<int,string> pair in filmesDic)
            {
                Console.WriteLine($"a chave {pair.Key} tem o valor {pair.Value} ");
            }
            //ou sem declarar quais os tipos de valor: 



            Console.WriteLine("---------");
            Console.WriteLine("Both On var");

            foreach (var pair in filmesDic)
            {
                Console.WriteLine($"a chave {pair.Key} tem o valor {pair.Value} ");
            }

        }





    }
}
