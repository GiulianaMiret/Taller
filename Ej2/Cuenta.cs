using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        public Cuenta (double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = 0;
        }

        /*public Cuenta (double pSaldoInicial, double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = pSaldoInicial;
        }*/

        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
            set { this.iAcuerdo = value; }
        }

        public void AcreditarSaldo (double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo (double pSaldo)
        {
            if (this.iSaldo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
                return true;
            }
            else
            {
                double aux = pSaldo - this.iSaldo;
                if (this.iAcuerdo >= aux)
                {
                    this.iSaldo = 0;
                    this.iAcuerdo -= aux;
                    return true;
                }
                else { return false; }
            }
        }
    }
}
