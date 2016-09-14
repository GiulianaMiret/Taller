using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Fecha
    {
        private const int Anio_Base = 1900;
        private const int Anio_Max = 2499;
        private static readonly int[] Cant_Dias_Mes = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] ClaveMes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static readonly String[] DIA_SEMANA = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
        private readonly long iCantidadDias;
        private readonly int iDia;
        private readonly int iMes;
        private readonly int iAnio;
        // public Fechas(int pDia , int pMes, int pAnio);
        //Metodo
        private static int CalcularCantidadDiasMes(int pDias, int pMes, int pAnio)
        {
            if (pDias)
            { int mCantidadDias -= 1; }

        }
        public Fechas AgregarDias(int pCantidadDias)
        {
			return;
        }

        public Fecha(string fdias, string fmes, string fanio)//Constructor.
        {
            this.iDias = fdias;
            this.iMes = fmes;
            this.iAnio = fanio;
        }

        public string dias//Propiedad.
        {
            get { return this.iDias; }
        }
        public string mes//Propiedad.
        {
            get { return this.iMes; }
        }
        public string anio//Propiedad.
        {
            get { return this.iAnio; }
        }
        //string.Format nos permita formatea una cadena de caracteres .
        public int CompararFecha(Fechas Fech)
        {

        }

        public string agregardia(string dia) //Metodo.
        {

        }
        public string agregarmes(string dia) //Metodo.
        {

        }
        public string agregaranio(string dia) //Metodo.
        {

        }
    }
