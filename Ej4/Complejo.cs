using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Complejo
    {
        private double iReal;
        private double iImaginario;
        
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
            Complejo num = new Complejo(0,0);
            num.iImaginario = -this.iImaginario;
            num.iReal = this.iReal;
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
            if(this.iImaginario == 0)
            {
                return true;
            }
            return false;
        }

        public bool EsImaginario()
        {
            if(this.iReal == 0)
            {
                return true;
            }
            return false;
        }

        public bool EsIgual (Complejo pOtroComplejo)
        {
            if (this.iImaginario == pOtroComplejo.iImaginario)
            {
                if (this.iReal == pOtroComplejo.iReal)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool EsIgual (double pReal, double pImaginario)
        {
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
            Complejo num = new Complejo(0,0);
            num.iReal = this.iReal + pOtroComplejo.iReal;
            num.iImaginario = this.iImaginario + pOtroComplejo.iImaginario;
            return num;
        }

        public Complejo Restar (Complejo pOtroComplejo)
        {
            Complejo num = new Complejo(0, 0);
            num.iReal = this.iReal - pOtroComplejo.iReal;
            num.iImaginario = this.iImaginario - pOtroComplejo.iImaginario;
            return num;
        }

        public Complejo MultiplicarPor (Complejo pOtroComplejo)
        {
            // (a + bi) · (c + di) = (ac − bd) + (ad + bc)i
            Complejo num = new Complejo(0, 0);
            num.iReal = this.iReal * pOtroComplejo.iReal;
            num.iReal -= this.iImaginario * pOtroComplejo.iImaginario;
            num.iImaginario = this.iReal * pOtroComplejo.iImaginario;
            num.iImaginario += this.iImaginario * pOtroComplejo.iReal;
            return num;
        }

        public Complejo DividirPor (Complejo pOtroComplejo)
        {
            //(a+bi) = ac+bd   +   bc-ad i
            //(c+di)   cc+dd       cc+dd
            Complejo num = new Complejo(0, 0);
            num.iReal = this.iReal * pOtroComplejo.iReal + this.iImaginario * pOtroComplejo.iImaginario;
            num.iReal = num.iReal / (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2));
            num.iImaginario = this.iImaginario * pOtroComplejo.iReal - this.iReal * pOtroComplejo.iImaginario;
            num.iImaginario = num.iImaginario / (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2));
            return num;
        }
    }
}

