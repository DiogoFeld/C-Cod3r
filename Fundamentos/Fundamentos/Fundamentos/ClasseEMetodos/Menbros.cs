using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{
    internal class Menbros
    {
        public void Main()
        {
            Pessoa adre = new Pessoa()
            {
                Nome = "adre",
                Sobreme = "martins",
                idade = 44,
                email = "andre@martis"
            };
            Console.WriteLine(adre.Apresetacao());
            Console.WriteLine($"O {adre.Nome} tem seu email como sendo {adre.email} e tem {adre.idade} anos");
        }






    }
}
