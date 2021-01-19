using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Punto p1 = new Punto2D();
            Punto p2 = new Punto2D(2, 5);
            p1.X = 3;
            p1.Y = 3;
            MessageBox.Show(p1.X + "," + p1.Y);
            MessageBox.Show(p2.X + "," + p2.Y);
            MessageBox.Show("Distancia de p1 al origen: " + p1.CalcularDistancia());
            MessageBox.Show("Distancia de p1 a p2: " + p1.CalcularDistancia(p2));
            //MessageBox.Show("Distancia de p1 a p2: " + Punto.CalcularDistancia(p1,p2));
            

            Punto3D p3 = new Punto3D();
            Punto3D p4 = new Punto3D(2,1,3);
            p3.X = 2;
            p3.Y = 5;
            p3.Z = 6;
            MessageBox.Show("Distancia de p3 al origen: " + p3.CalcularDistancia());
            MessageBox.Show("Distancia de p3 a p4: " + p3.CalcularDistancia(p4));
            MessageBox.Show("Cantidad de punto: " + Punto.contador);
        }
    }
}
