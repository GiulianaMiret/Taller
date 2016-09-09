using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro.X = pX;
            this.iCentro.Y = pY;
            this.iRadio = pRadio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(this.iRadio, 2);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * this.iRadio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
        }

        public double Radio
        {
            get { return this.iRadio; }
        }
    }
}