using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OO
{
    class Heranca
    {
        public void Main()
        {
            Console.WriteLine("O uno irá...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.acelerar());
            Console.WriteLine(carro1.acelerar());
            Console.WriteLine(carro1.acelerar());
            Console.WriteLine(carro1.frear());

            Ferrari carro2 = new Ferrari();
            Console.WriteLine("A Ferrari irá...");
            Console.WriteLine(carro2.acelerar());
            Console.WriteLine(carro2.acelerar());
            Console.WriteLine(carro2.acelerar());
            Console.WriteLine(carro2.frear());


        }
    }





    //Classes de exemplo
    public class Carro
    {

        protected readonly int velocidadeMax;
        int velocidadeAtual;

                
        public Carro(int velocidadeMax)
        {
            this.velocidadeMax = velocidadeMax;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = velocidadeAtual + delta;
            novaVelocidade  = novaVelocidade < 0 ? 0 : novaVelocidade;    
            novaVelocidade  = velocidadeAtual > velocidadeMax ? velocidadeMax : novaVelocidade;

            velocidadeAtual = novaVelocidade;
            return novaVelocidade;
        }

        public virtual int acelerar()
        {
            //virtual permite a sobreescrita com override
            return AlterarVelocidade(5);
        }

        public int frear()
        {
            return AlterarVelocidade(-5);
        }
    }



    public class Uno : Carro
    {
        //chama a classe contrutora Carro()
        public Uno() : base(180) { }
    }


    public class Ferrari : Carro
    {
        //chama a classe contrutora Carro()
        public Ferrari() : base(350) { }
        // substitui a classe acima colocada
        public override int acelerar()
        {
            return AlterarVelocidade(20);
        }

        public new int frear()
        {
            //'new' sobreescreva sem muito problema para o medoto original
            return AlterarVelocidade(-10);
        }



    }
}
