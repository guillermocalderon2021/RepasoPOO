using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWindows
{
    class Punto3D:Punto
    {
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Punto3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            contador++;
        }

        public Punto3D(double _x, double _y, double _z)
        {
            this.x = _x;
            this.y = _y;
            this.z = _z;
            contador++;
        }

        public override double CalcularDistancia()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z,2));
        }

        public override double CalcularDistancia(Punto p2)
        {
            return Math.Sqrt(Math.Pow(this.x - ((Punto3D)p2).x, 2) + Math.Pow(this.y - ((Punto3D)p2).y, 2) + Math.Pow(this.z-((Punto3D)p2).z,2));
        }
    }
}
