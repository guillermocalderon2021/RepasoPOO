using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWindows
{
    sealed class Punto2D : Punto
    {
        public Punto2D(int _x, int _y)
        {

            this.x = _x;
            this.y = _y;
            contador++;
        }

        public Punto2D()
        {
            this.x = 0;
            this.y = 0;
            contador++;
        }

        public override double CalcularDistancia()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public override double CalcularDistancia( Punto p2)
        {

            return Math.Sqrt(Math.Pow(this.x -((Punto2D) p2).x, 2) + Math.Pow(this.y - ((Punto2D)p2).y, 2));
        }
    }

    
}
