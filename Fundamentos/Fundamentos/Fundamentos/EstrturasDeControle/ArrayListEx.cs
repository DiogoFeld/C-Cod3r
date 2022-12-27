using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstrturasDeControle
{
    internal class ArrayListEx
    {
        public void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Nome");
            arrayList.Add(1);
            arrayList.Add(new Produto("s",0));
            printArrayList(arrayList);


        }

        void printArrayList(ArrayList lista)
        {
            foreach (var p in lista)
            {
                Console.WriteLine(p);

            }
            Console.WriteLine("------------------");
        }


    }
}
