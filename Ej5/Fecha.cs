using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Fecha
    {
        private readonly string iDia;
        private readonly string iMes;
        private readonly string iAnio;

        public string AgregarDia (string pDia)
        {
            

        }
        public string idias { get; }
        public string imes { get; }
        public string ianio { get; }

        private const int Anio_Base = 1900;
        private const int Anio_Max = 2499;
        private static readonly int[] Cant_Dias_Mes = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] ClaveMes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
            return
        }

        public Fechas(string fdias, string fmes, string fanio)//Constructor.
        {
            idias = fdias;
            imes = fmes;
            ianio = fanio;
        }

        public string dias//Propiedad.
        {
            get { return this.idias; }
        }
        public string mes//Propiedad.
        {
            get { return this.imes; }
        }
        public string anio//Propiedad.
        {
            get { return this.ianio; }
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
