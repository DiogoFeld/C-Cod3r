using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Api
{
    internal class DiretorioInfoObj
    {
        public void Main()
        {
            var dirProjeto = @"~/pastaCSharpDestino2".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }


            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            var diretorio= dirInfo.GetDirectories();
            foreach (var dirs in diretorio)
            {
                Console.WriteLine(dirs);
            }

        }


    }
}
