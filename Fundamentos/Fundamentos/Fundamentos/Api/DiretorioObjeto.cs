using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Api
{
    internal class DiretorioObjeto
    {
        public void Main()
        {
            var novoDir = @"~/pastaCSharp".ParseHome();
            var novoDirDestino = @"~/pastaCSharpDestino".ParseHome();
            var DirProjeto = @"~/Estudos Programação/C#Cod3r/Fundamentos/Fundamentos/Fundamentos".ParseHome();


            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir,true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Directory.Move(novoDir, novoDirDestino);


            //var pastas = Directory.GetDirectories(DirProjeto);//only in C main directorory
            //foreach(var pasta in pastas){
            //    Console.WriteLine(pasta);
            //}
        }





    }
}
