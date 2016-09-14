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
        private readonly long iCantidadDias;
        private readonly int iDia;
        private readonly int iMes;
        private readonly int iAño;
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

        public int Dias//Propiedad.
        {
            get { return this.iDia; }
        }
        public int Mes//Propiedad.
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

        public Fecha AgregarMeses(int cantMes)
        {
            int cantDias = 0;
            int mesActual = this.iMes;
            int añoActual = this.iAño;
            for (int i = 1; i <= cantMes; i++)
            {
                if (mesActual == 12)
                {
                    mesActual = 1;
                    añoActual += 1;
                }
                else
                {
                    mesActual += 1;
                }
                cantDias += Fecha.CalcularCantidadDiasMes(mesActual, añoActual);
            }
            return new Fecha(this.iCantidadDias + cantDias);
        }

        private Fecha(long pCantidadDias)
        {
            //Falta hacer
        }



        public string agregaranio(string dia) //Metodo.
        {

        }
    }
