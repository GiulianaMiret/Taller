using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCajaAhorro;
        private Cuenta iCuentaCorriente;


       public Cuentas()
        {
            this.iCliente = new Cliente(TipoDocumento.DNI, "32554952", "Anacleto");
            this.iCajaAhorro = new Cuenta(100);
            this.iCuentaCorriente = new Cuenta(100);
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }
    }
}