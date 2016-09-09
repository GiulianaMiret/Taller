using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Complejo
    {
        private readonly double iReal;
        private readonly double iImaginario;
        
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        public double Real
        {
            get { return this.iReal; }
        }

        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        public double ArgumentoEnRadianes ()
        {
            double num = Math.Atan(this.iReal / this.iImaginario);
            if (this.iImaginario < 0)
            {
                num = (-180/2) - num;
                num = (num * Math.PI)/180;
            }
            else {num = (180/2) - num; num = (num* Math.PI)/180;}
            return num;
        }

        public double ArgumentEnGrados()
        {
            double num = Math.Atan(this.iReal / this.iImaginario);
            if (this.iImaginario < 0)
            {
                num = (-180/2) - num;
            }
            else {num = (180/2) - num;}
            return num;
        }

        public Complejo Conjugado()
        {
            Complejo num = new Complejo(this.iReal, -this.iImaginario);
            return num;
        }

        public double Magnitud()
        {
            // sqrt(real^2 + imag^2)
            double num = Math.Pow(this.iReal, 2) + Math.Pow(this.iImaginario, 2);
            num = Math.Sqrt(num);
            return num;
        }

        public bool EsReal()
        {
            return (this.iImaginario == 0);
        }

        public bool EsImaginario()
        {
            return (this.iReal == 0);
        }

        private static bool EsIgual (Complejo pOtroComplejo)
        {
            if (iImaginario == pOtroComplejo.iImaginario)
            {
                if (iReal == pOtroComplejo.iReal)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private static bool EsIgual (double pReal, double pImaginario)
        {
            //return (this.iReal == pReal );
            if (this.iReal == pReal)
            {
                if (this.iImaginario == pImaginario)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public Complejo Sumar (Complejo pOtroComplejo)
        {
            Complejo num = new Complejo(this.iReal + pOtroComplejo.iReal, this.iImaginario + pOtroComplejo.iImaginario);
            return num;
        }

        public Complejo Restar (Complejo pOtroComplejo)
        {
            Complejo num = new Complejo(this.iReal - pOtroComplejo.iReal, this.iImaginario - pOtroComplejo.iImaginario);
            return num;
        }

        public Complejo MultiplicarPor (Complejo pOtroComplejo)
        {
            // (a + bi) · (c + di) = (ac − bd) + (ad + bc)i
            double auxReal = this.iReal * pOtroComplejo.iReal;
            auxReal = auxReal - this.iImaginario * pOtroComplejo.iImaginario;
            double auxImag = this.iReal * pOtroComplejo.iImaginario;
            auxImag = auxImag + this.iImaginario * pOtroComplejo.iReal;
            Complejo num = new Complejo(auxReal, auxImag);
            return num;
        }

        public Complejo DividirPor (Complejo pOtroComplejo)
        {
            //(a+bi) = ac+bd   +   bc-ad i
            //(c+di)   cc+dd       cc+dd
            double auxReal = this.iReal * pOtroComplejo.iReal + this.iImaginario * pOtroComplejo.iImaginario;
            auxReal = auxReal  / (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2));
            double auxImag = this.iImaginario * pOtroComplejo.iReal - this.iReal * pOtroComplejo.iImaginario;
            auxImag = auxImag / (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2));
            Complejo num = new Complejo(auxReal, auxImag);
            return num;
        }
    }
}

