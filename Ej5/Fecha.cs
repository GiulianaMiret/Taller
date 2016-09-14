﻿using System;
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
        private readonly int iAnio;
        // public Fechas(int pDia , int pMes, int pAnio);
        //Metodo
        private static int CalcularCantidadDiasMes(int pDias, int pMes, int pAnio)
        {
            if (pDias)
            { int mCantidadDias -= 1; }

        }
		private static int CalcularCantidadDiasAnio(int anio){
			int cantidadDias = 365;

			if Fecha.EsBisiesto(anio){
				cantidadDias++;
			}

			return cantidadDias;
		}

        public Fechas AgregarDias(int pCantidadDias)
        {
			return;
        }

		public Fecha AgregarAnios(int pAnios)
		{
			int cantidadDias = 0;

			for (int indice = 1; indice < pAnios; indice++) {
				cantidadDias += Fecha.CalcularCantidadDiasAnio (this.iAnio + indice);
			}

			return new Fecha (this.iCantidadDias + cantidadDias);
		}

        public Fecha(string fdias, string fmes, string fanio)//Constructor.
        {
            this.iDias = fdias;
            this.iMes = fmes;
            this.iAnio = fanio;
        }

		public Fecha(long pCantidadDias){
			if (pCantidadDias < 1 || pCantidadDias > 219146) {
				throw new ArgumentException ("La cantidad de dias debe estar comprendida entre 1 y 219146");
			}
			this.iCantidadDias = pCantidadDias;
			int anioActual = Anio_Base;
			int mCantidadDiasAñoActual = Fecha.CalcularCantidadDiasAnio (anioActual);

			while (pCantidadDias > mCantidadDiasAñoActual) {
				anioActual++;
				pCantidadDias -= mCantidadDiasAñoActual;
				mCantidadDiasAñoActual = Fecha.CalcularCantidadDiasAnio (anioActual);
			}
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
        public string AgregarAnios(int pAnio) //Metodo.
        {
			int cantidadDias = 0;
			for (int indice = 1; indice <= pAnio; indice++) {
				cantidadDias += Fecha.CalcularCantidadDiasAño(this.iAnio + indice);
			}
			return new Fecha (this.iCantidadDias + cantidadDias);
        }
    }
