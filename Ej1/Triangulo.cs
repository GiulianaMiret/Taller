using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;


        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }
        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }
        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }

        public double Area()
        {
            // base *altura )/2      P=perim/2   A=sqrt(p*(p-lad1)*(p-lad2)*(p-lad3) )
            Punto aux = new Punto(this.iPunto1.X, this.iPunto1.Y);
            double ladoA = aux.CalcularDistanciaDesde(this.iPunto2); //calcula distancia entre el punto 1 y 2
            double ladoB = aux.CalcularDistanciaDesde(this.iPunto3); //calcula distancia entre el punto 1 y 3
            aux = this.iPunto2;
            double ladoC = aux.CalcularDistanciaDesde(this.iPunto3); //calcula distancia entre el punto 2 y 3
            double sP = (ladoA + ladoB + ladoC) / 2; //sP = Semi perimetro
            double aux2 = sP * (sP - ladoA) * (sP - ladoB) * (sP - ladoC);
            return Math.Sqrt(aux2);
        }

        public double Perimetro()
        {
            Punto aux = new Punto(this.iPunto1.X, this.iPunto1.Y);
            double sumaLados = aux.CalcularDistanciaDesde(this.iPunto2); //calcula distancia entre el punto 1 y 2
            sumaLados += aux.CalcularDistanciaDesde(this.iPunto3); //calcula distancia entre el punto 1 y 3
            aux = this.iPunto2;
            sumaLados += aux.CalcularDistanciaDesde(this.iPunto3); //calcula distancia entre el punto 2 y 3
            return sumaLados;
        }
    }
}
