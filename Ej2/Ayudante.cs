using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Ayudante
    {

        public TipoDocumento AsignarTipo(int tipoDoc)
        {
            TipoDocumento td = TipoDocumento.DNI;
            switch (tipoDoc)
            {
                case 1:
                    td = TipoDocumento.DNI;
                    break;
                case 2:
                    td = TipoDocumento.Cuit;
                    break;
                case 3:
                    td = TipoDocumento.Cuil;
                    break;
                case 4:
                    td = TipoDocumento.LE;
                    break;
                case 5:
                    td =TipoDocumento.LC;
                    break;
            }
            return td;
        }

        public double Descontar (double saldo, int auxP, Cuentas cuentas)
        {
            double auxSaldo = -99;
            if (auxP == 1)
            {
                bool varAux = cuentas.CajaAhorro.DebitarSaldo(saldo);
                if (varAux == true)
                {
                    auxSaldo = cuentas.CajaAhorro.Saldo;
                }
            }
            else
            {
                if (auxP == 2)
                {
                    bool varAux = cuentas.CuentaCorriente.DebitarSaldo(saldo);
                    if (varAux == true)
                    {
                        auxSaldo = cuentas.CajaAhorro.Saldo;
                    }
                }
            }
            return auxSaldo;
        }


        public double Acreditar (double saldo, int auxP, Cuentas cuentas)
        {
            if (auxP == 1)
            {
                cuentas.CajaAhorro.AcreditarSaldo(saldo);
                saldo = cuentas.CajaAhorro.Saldo;
                //return saldo;
            }
            else
            {
                if (auxP == 2)
                {
                    Console.Clear();
                    cuentas.CuentaCorriente.AcreditarSaldo(saldo);
                    saldo = cuentas.CuentaCorriente.Saldo;
                    //return saldo;
                }
            }
            return saldo;
        }


        public bool Transferir (double auxSaldo ,int aux, Cuentas cuentas)
        {
            bool devolver = false;
            if (aux == 1)
            {
                bool var = cuentas.CajaAhorro.DebitarSaldo(auxSaldo);
                if (var == true)
                {
                    cuentas.CuentaCorriente.AcreditarSaldo(auxSaldo);
                    devolver = true;
                }
            }
            else
            {
                if (aux == 2)
                {
                    bool var = cuentas.CuentaCorriente.DebitarSaldo(auxSaldo);
                    if (var == true)
                    {
                        cuentas.CajaAhorro.AcreditarSaldo(auxSaldo);
                        devolver = true;
                    }
                }
            }
            return devolver;
        }




    }
}
