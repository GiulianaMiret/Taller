using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class Fecha
    {
        private readonly DateTime iFecha;
        private static readonly int[] DiasMes = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] ClaveMes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static readonly String[] DIASEMANA = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

        public int Dia
        {
            get { return this.iFecha.Day; }
        }

        public int Mes
        {
            get { return this.iFecha.Month; }
        }

        public int Año
        {
            get { return this.iFecha.Year; }
        }

        public Fecha (int dia, int mes, int año)
        {
            if (mes > 0 || mes < 13)
            {
                if (dia > 0 || dia <= CantidadDiasDelMes(mes,año))
                {
                    this.iFecha = new DateTime(año, mes, dia);
                }
            }
            
        }

        public Fecha AgregarDia(int cantidadDias)
        {
            DateTime aux = this.iFecha.AddDays(cantidadDias);
            return new Fecha(aux.Day, aux.Month, aux.Year);
        }

        public Fecha AgregarMes(int cantdadMeses)
        {
            DateTime aux = this.iFecha.AddMonths(cantdadMeses);
            return new Fecha(aux.Day, aux.Month, aux.Year);
        }

        public Fecha AgregarAño(int cantidadAños)
        {
            DateTime aux = this.iFecha.AddYears(cantidadAños);
            return new Fecha(aux.Day, aux.Month, aux.Year);
        }

        private static int CantidadDiasDelMes (int mes, int año)
        {
            int cantidadDias = DiasMes[mes];
            if(mes == 2 && DateTime.IsLeapYear(año))
            {
                cantidadDias++;
            }
            return cantidadDias;
        }

        private static int CantidadDiasDelAño (int año)
        {
            int cantidadDias = 365;
            if (DateTime.IsLeapYear(año))
            {
                cantidadDias++;
            }
            return cantidadDias;
        }

        public string DiaDeLaSemana ()
        {
            DateTime aux = this.iFecha;
            return DIASEMANA[Convert.ToInt32(aux.DayOfWeek)];
        }

        public bool EsBiciesto ()
        {
            return DateTime.IsLeapYear(this.iFecha.Year);
        }

        public int CompararFechas (Fecha fecha)
        {
            return this.iFecha.CompareTo(fecha.iFecha);
        }
    }
}
