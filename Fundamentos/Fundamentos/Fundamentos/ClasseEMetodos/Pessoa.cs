using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    class Pessoa
    {

        public string Nome;
        public string Sobreme;
        public string email;
        public int idade;

        public string Apresetacao()
        {
            return string.Format($"ola me chamo {Nome} {Sobreme}");
        }


        public void Zerar()
        {
            Nome = "";
            Sobreme = "";
            email = "";
            idade = 0;
        }


    }
}
