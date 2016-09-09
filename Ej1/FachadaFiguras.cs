using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class FachadaFiguras
    {

        public double CalcularPerimetroTriangulo (double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Punto punto1 = new Punto(x1, y1);
            Punto punto2 = new Punto(x2, y2);
            Punto punto3 = new Punto(x3, y3);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return triangulo.Perimetro();
        }

        public double CalcularAreaTriangulo(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Punto punto1 = new Punto(x1, y1);
            Punto punto2 = new Punto(x2, y2);
            Punto punto3 = new Punto(x3, y3);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return triangulo.Area();
        }

        public double CalcularPerimetroCirculo(double x, double y, double rad)
        {
            Punto centro = new Punto(x, y);
            Circulo circulo = new Circulo(centro, rad);
            return circulo.Perimetro();
        }

        public double CalcularAreaCirculo(double x, double y, double rad)
        {
            Punto centro = new Punto(x, y);
            Circulo circulo = new Circulo(centro, rad);
            return circulo.Area();
        }
    }
}
