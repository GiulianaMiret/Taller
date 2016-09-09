using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    enum TipoDocumento { DNI, Cuit, Cuil, LE, LC };
    class Cliente
    {
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        public Cliente (TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
            this.iTipoDocumento = pTipoDocumento;
        }

        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
            set { this.iTipoDocumento = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public string NroDocumento
        {
            get { return this.iNroDocumento; }
            set { this.iNroDocumento = value; }
        }
    }
}