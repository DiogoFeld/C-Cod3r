using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fundamentos.Api
{
    internal class LendoArquivos
    {
        public void Main()
        {
            var path = "~/lendo_Arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("produto;preco;qtde");
                    sw.WriteLine("Caneta BIC;1.99;5");
                    sw.WriteLine("Borracha;4.5;2");
                    sw.WriteLine("Lapis;3;2");
                }
            }
            else
            {
                try
                {

                    using (StreamReader sr = new StreamReader(path))
                    {
                        var text = sr.ReadToEnd();
                        Console.WriteLine(text);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
        }
    }
}
