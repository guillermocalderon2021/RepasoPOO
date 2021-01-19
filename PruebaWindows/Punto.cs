using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWindows
{
    abstract class Punto
    {

        static public int contador;
        protected double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        protected double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        abstract public double CalcularDistancia();
        abstract public double CalcularDistancia(Punto p2);
        //abstract static public double CalcularDistancia(Punto p1, Punto p2);
        /*
        {
           
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }*/


        /*
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }

        public void setX(double _x)
        {
            this.x = _x;
            
        }

        public void setY(double _y)
        {
            this.y = _y;

        }*/
    }
}
