using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ClasseEMetodos
{

    interface Ponto
    {        
        void MoveDiagonal(int i);
    }


    struct Coordenada : Ponto
    {
        public int x;
        public int y;      
        public Coordenada(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveDiagonal(int i)
        {
            x += i;
            y += i;            
        }
    }

    public class Struct
    {
        public void Main()
        {
            Coordenada coordenada;
            coordenada.y = 2;
            coordenada.x = 1;
            Console.WriteLine("Coordenada inicial é x {0} e y {1}", coordenada.y, coordenada.x);
            coordenada.MoveDiagonal(5);
            Console.WriteLine("Coordenada final é x {0} e y {1}", coordenada.y, coordenada.x);
            Coordenada coordenada1 = new Coordenada(4,1);
        }
    }






}
