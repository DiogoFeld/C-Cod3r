using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Advanced
{
    internal class Linq2
    {
        public void Main()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno("joao", 14,7.8),
                new Aluno("maria", 9,2.2),
                new Aluno("joao alberto", 12,9.4),
                new Aluno("andre", 15,7.2),
                new Aluno("andrei", 16,6.8),
                new Aluno("ana", 20,9.8),
                new Aluno("Maria julia", 24,4.5),
                new Aluno("ana", 20,5.4),//essa ultima ana demonstra o uso do First e do Last -> bom pra pegar datas
            };

            Console.WriteLine("apenas 1");
            var pedro = alunos.Single(a => a.Name.Equals("joao"));
            Console.WriteLine($"{pedro.Name} tirou {pedro.Nota} e te, {pedro.Idade} anos");


            Console.WriteLine("e o fulano? ");
            var fulano = alunos.SingleOrDefault(a => a.Name.Equals("fulano"));
            if(fulano == null)//default no caso retorna nulo
            {
                Console.WriteLine($"Fulano é nulo");
            }
            Console.WriteLine("ana 1");
            var ana = alunos.First(a => a.Name.Equals("ana"));
            Console.WriteLine($"ana é {ana.Name} tirou {ana.Nota}");

            var ana2 = alunos.FirstOrDefault(a => a.Name.Equals("ana2"));
            Console.WriteLine($"ana é {ana2}");//mesma coisa do fulano

            Console.WriteLine("ana '3'");
            var ana3 = alunos.Last(a => a.Name.Equals("ana"));
            Console.WriteLine($"ana é {ana3.Name} tirou {ana3.Nota}");//perceba a diferença


            Console.WriteLine("Skip ");
            var examploSkip = alunos.Skip(1).Take(3);
            //pega os proximos 3 depois de 1 --> imagina isso dentro de uma pagina de produtos pegos via preço, 10 por pagina, super bom
            foreach(var item in examploSkip)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("max ");
            var max = alunos.Max(a => a.Nota);
            Console.WriteLine(max);

            Console.WriteLine("min ");
            var min = alunos.Min(a => a.Nota);
            Console.WriteLine(min);

            Console.WriteLine("average ");
            var media = alunos.Average(a => a.Nota);
            Console.WriteLine(media);

            Console.WriteLine("average aprovados ");
            var mediaAprovados = alunos.Where(a => a.Nota > 7).Average(a => a.Nota);
            Console.WriteLine(mediaAprovados);

        }
    }
}
