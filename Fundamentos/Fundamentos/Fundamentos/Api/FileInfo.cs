using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Api
{
    internal class FileInfoOO
    {

        public static void ExcluirSeExistir(params string[] names)
        {
            foreach(string name in names)
            {
                FileInfo file = new FileInfo(name);
                if (file.Exists)
                {
                    file.Delete();
                }
            }
        }


        public void Main()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_Copia.txt".ParseHome();


            using(StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("caminho original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.Extension);


            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }






    }
}
