using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Fecha
    {
        private readonly long iCantidadDias;
        private readonly int iDia;
        private readonly int iMes;
        private readonly int iAño;

        private const int Año_Base = 1900;
        private const int Año_Max = 2499;
        private static readonly int[] Cant_Dias_Mes = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] ClaveMes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        // public Fechas(int pDia , int pMes, int pAnio);
        //Metodo
        private static int CalcularCantidadDiasMes(int pDia, int pMes, int pAño)
        {
            if (pDia)
            { int mCantidadDias -= 1; }

        }
        public Fecha AgregarDias(int pCantidadDias)
        {
            return
        }

        public Fecha(int fdia, int fmes, int faño)//Constructor.
        {
           this.iDia = fdia;
            this.iMes = fmes;
            this.iAño = faño;
        }

        public string dias//Propiedad.
        {
            get { return this.iDia; }
        }
        public string mes//Propiedad.
        {
            get { return this.iMes ; }
        }
        public string año//Propiedad.
        {
            get { return this.iAño; }
        }
        //string.Format nos permita formatea una cadena de caracteres .
        public int CompararFecha(Fechas Fech)
        {

        }

        public string agregardia(int dia) //Metodo.
        {

        }
        public string agregarmes(int mes) //Metodo.
        {

        }
        public string agregaraño(int año) //Metodo.
        {

        }
    }
