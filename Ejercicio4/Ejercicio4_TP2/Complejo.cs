using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_TP2
{
    public class Complejo
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

            public double ArgumentoEnRadianes()
            {
                double num = this.iImaginario / this.iReal;
                num = Math.Atan(num);
                //num *= 180 / Math.PI;
                if (this.iImaginario >= 0)
                {
                    if (this.iReal < 0) { num = Math.PI - num; }
                    else { return num; }
                }
                else
                {
                    if (this.iReal < 0) { num = Math.PI + num; }
                    else { num = 2*Math.PI - num; }
                }
                //num *= Math.PI / 180;
                return num;
            }

            public double ArgumentEnGrados()
            {
                double num = this.iImaginario / this.iReal;
                num = Math.Atan(num);
                num *= 180 / Math.PI;
                if (this.iImaginario >= 0)
                {
                    if (this.iReal < 0) { num = 180 - num; }
                    //else { return num; }
                }
                else
                {
                    if (this.iReal < 0) { num = 180 + num; }
                    else { num = 360 - num; }
                }
                return num;
            }

            public Complejo Conjugado()
            {
                Complejo num = new Complejo(this.iReal, - (this.iImaginario));
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

            public bool EsIgual(Complejo pOtroComplejo)
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

            private bool EsIgual(double pReal, double pImaginario)
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

            public Complejo Sumar(Complejo pOtroComplejo)
            {
                double real = this.iReal + pOtroComplejo.iReal;
                double imag = this.iImaginario + pOtroComplejo.iImaginario;
                Complejo num = new Complejo(real, imag);
                return num;
            }

            public Complejo Restar(Complejo pOtroComplejo)
            {
            double real = this.iReal - pOtroComplejo.iReal;
            double imag = this.iImaginario - pOtroComplejo.iImaginario;
            Complejo num = new Complejo(real, imag);
            return num;
            }

            public Complejo MultiplicarPor(Complejo pOtroComplejo)
            {
                // (a + bi) · (c + di) = (ac − bd) + (ad + bc)i
                double auxReal = this.iReal * pOtroComplejo.iReal;
                auxReal -= (this.iImaginario * pOtroComplejo.iImaginario);
                double auxImag = this.iReal * pOtroComplejo.iImaginario;
                auxImag += (this.iImaginario * pOtroComplejo.iReal);
                Complejo num = new Complejo(auxReal, auxImag);
                return num;
            }

            public Complejo DividirPor(Complejo pOtroComplejo)
            {
                //(a+bi) = ac+bd   +   bc-ad i
                //(c+di)   cc+dd       cc+dd
                double auxReal = this.iReal * pOtroComplejo.iReal + this.iImaginario * pOtroComplejo.iImaginario;
                auxReal = auxReal / (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2));
                double auxImag = this.iImaginario * pOtroComplejo.iReal - this.iReal * pOtroComplejo.iImaginario;
                auxImag = auxImag / (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2));
                Complejo num = new Complejo(auxReal, auxImag);
                return num;
            }
        }
    }