using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Punto
    {
        private double iX;
        private double iY;

        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        public double X
        {
            get { return this.iX;}
            set { this.iX = value; }
        }

        public double Y
        {
            get { return this.iY; }
            set { this.iY = value; }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double aux = Math.Pow(pPunto.iX - this.iX, 2);
            aux += Math.Pow(pPunto.iY - this.iY, 2);
            return Math.Sqrt(aux); 
        }
    }
} 
