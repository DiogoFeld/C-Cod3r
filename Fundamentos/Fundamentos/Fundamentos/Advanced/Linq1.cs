using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Advanced
{
    public class Aluno
    {
        public string Name;
        public int Idade;
        public double Nota;

        public Aluno(string name, int idade, double nota)
        {
            Name = name;
            Idade = idade;
            Nota = nota;
        }
    }


    internal class Linq1
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
                new Aluno("Ana paula", 20,9.8),
                new Aluno("Maria julia", 24,4.5),
            };

            Console.WriteLine("Todos");
            var todos = alunos.Where(a => true);
            foreach (Aluno aluno in todos)
            {
                Console.WriteLine(aluno.Name);
            }


            Console.WriteLine("=====Aprovados=======");
            var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Name);
            foreach(Aluno aluno in aprovados)
            {
                Console.WriteLine(aluno.Name);
            }

            Console.WriteLine("=====Chamada=======");
            var nomesApenas = alunos.OrderBy(a => a.Name).Select(a => a.Name);
            foreach (string sNome in nomesApenas)
            {
                Console.WriteLine(sNome);
            }

            Console.WriteLine("=====Aprovados por idade=======");
            var aprovadosIdade =
                from aluno in alunos
                where aluno.Nota > 7
                where aluno.Idade > 14
                orderby aluno.Name
                select aluno.Name;
                //alunos.Where(a => a.Nota > 7).Where(a => a.Idade > 14).OrderBy(a => a.Name);
                //retorna uma lista de nomes dos alunos com os casos colocados

            foreach (string alunoIdade in aprovadosIdade)
            {
                Console.WriteLine(alunoIdade);
            }



        }
    }
}
