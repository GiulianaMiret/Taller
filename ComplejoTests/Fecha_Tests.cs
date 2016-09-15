using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaTests
{
    [TestClass()]
    public class Fecha_Tests
    {
        [TestMethod()]
        public void AgregarDiaTest()
        {
            Fecha fecha = new Fecha(19, 9, 2016);
            fecha = fecha.AgregarDia(34);
            Fecha esperada = new Fecha(23, 10, 2016);
            Assert.AreEqual(0, fecha.CompararFechas(esperada));
        }

        [TestMethod()]
        public void AgregarMesTest()
        {
            Fecha fecha = new Fecha(20, 9, 2016);
            fecha = fecha.AgregarMes(3);
            Fecha esperada = new Fecha(20, 12, 2016);
            Assert.AreEqual(0, fecha.CompararFechas(esperada));
        }

        [TestMethod()]
        public void AgregarAñoTest()
        {
            Fecha fecha = new Fecha(29, 9, 2016);
            fecha = fecha.AgregarAño(2);
            Fecha esperada = new Fecha(29, 9, 2018);
            Assert.AreEqual(0, fecha.CompararFechas(esperada));
        }

        [TestMethod()]
        public void DiaDeLaSemanaTest()
        {
            Fecha fecha = new Fecha(29, 9, 2016);
            string esperada = "Jueves";
            Assert.AreEqual(esperada, fecha.DiaDeLaSemana());
        }

        [TestMethod()]
        public void EsBiciestoTest()
        {
            Fecha fecha = new Fecha(29, 9, 2015);
            Assert.IsFalse(fecha.EsBiciesto());
        }

        [TestMethod()]
        public void EsBiciesto2Test()
        {
            Fecha fecha = new Fecha(29, 9, 2012);
            Assert.IsTrue(fecha.EsBiciesto());
        }

        [TestMethod()]
        public void CompararFechasTest()
        {
            Fecha fecha = new Fecha(29, 9, 2016);
            Assert.IsTrue(0 < fecha.CompararFechas(new Fecha(10, 5, 2000)));
        }

        [TestMethod()]
        public void CompararFechas2Test()
        {
            Fecha fecha = new Fecha(29, 9, 2016);
            Assert.AreEqual(0, fecha.CompararFechas(new Fecha(29, 9, 2016)));
        }

    }
}
