using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartesiano
{
    class Ponto
    {
        public double X { get; set;}
        public double Y { get; set; }

        public Ponto(double x, double y) 
        {
            this.X = x;
            this.Y = y;
        }

        public  static double Distancia(Ponto a, Ponto b) 
        {
            return Math.Sqrt(Math.Pow((a.X - b.Y), 2) + Math.Pow((a.X - b.Y), 2));
        }
    }
}
