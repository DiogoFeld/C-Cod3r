using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    public class Filme
    {
        public string Name { get; set; }
        public Genero GeneroFilme { get; set; }
    }
    public enum Genero { Acao, Aventura, Drama, Comedia, Terror };
    public class Enum
    {
        public void Main()
        {
            int id = (int)Genero.Acao;

            var filmeDeTerror = new Filme()
            {
                Name = "Panico no lago",
                GeneroFilme = Genero.Terror
            };

            Console.WriteLine("o filme é de {0}", filmeDeTerror.GeneroFilme);
        }
    }



}
