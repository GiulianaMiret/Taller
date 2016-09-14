using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio4_TP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_TP2.Tests
{
    [TestClass()]
    public class Complejo_Tests
    {
        [TestMethod()]
        public void ArgumentoEnRadianesTest()   //Problemas
        {
            Complejo numero = new Complejo(1,1);
            double retorna = numero.ArgumentoEnRadianes();
            double esperado = Math.Atan(1/ 1);
            Assert.AreEqual(esperado, retorna);
        }

        [TestMethod()]
        public void ArgumentEnGradosTest()      //Problemas
        {
            Complejo num = new Complejo(1, 1);
            double retorna = num.ArgumentEnGrados();
            double esperado = 45;
            Assert.AreEqual(esperado, retorna);
        }

        [TestMethod()]
        public void ConjugadoTest()  
        {
            Complejo numero = new Complejo(4, 4 * Math.Sqrt(3));
            Complejo retorna = numero.Conjugado();
            Complejo esperado = new Complejo(4, -4 * Math.Sqrt(3));
            Assert.AreEqual(esperado.Imaginario, retorna.Imaginario);
            Assert.AreEqual(esperado.Real, retorna.Real);
        }

        [TestMethod()]
        public void MagnitudTest()
        {
            Complejo numero = new Complejo(4, 3); // 4+3i
            double retorna = numero.Magnitud();
            double esperado = 5;
            Assert.AreEqual(esperado, retorna);
        }

        [TestMethod()]
        public void EsRealTest()
        {
            Complejo numero = new Complejo(1, 7);
            bool retorna = numero.EsReal();
            Assert.IsFalse(retorna);
        }

        [TestMethod()]
        public void EsReal2Test()
        {
            Complejo numero = new Complejo(1, 0);
            bool retorna = numero.EsReal();
            Assert.IsTrue(retorna);
        }

        [TestMethod()]
        public void EsImaginarioTest()
        {
            Complejo numero = new Complejo(1, 7);
            bool retorna = numero.EsImaginario();
            Assert.IsFalse(retorna);
        }

        [TestMethod()]
        public void EsImaginario2Test()
        {
            Complejo numero = new Complejo(0, 7);
            bool retorna = numero.EsImaginario();
            Assert.IsTrue(retorna);
        }

        [TestMethod()]
        public void EsIgualTest()
        {
            Complejo numero = new Complejo(2, 4);
            Complejo numCompara = new Complejo(2, 8);
            bool retorna = numero.EsIgual(numCompara);
            Assert.IsFalse(retorna);
        }

        [TestMethod()]
        public void SumarTest()    
        {
            Complejo numero = new Complejo(4, 5);
            Complejo numASumar = new Complejo(4, 6);
            Complejo retorna = numero.Sumar(numASumar);
            Complejo esperado = new Complejo(8, 11);
            Assert.AreEqual(esperado.Imaginario, retorna.Imaginario);
            Assert.AreEqual(esperado.Real, retorna.Real);
        }

        [TestMethod()]
        public void RestarTest()  
        {
            Complejo numero = new Complejo(4, 5);
            Complejo numARestar = new Complejo(4, 6);
            Complejo retorna = numero.Restar(numARestar);
            Complejo esperado = new Complejo(0, -1);
            Assert.AreEqual(esperado.Imaginario, retorna.Imaginario);
            Assert.AreEqual(esperado.Real, retorna.Real);
        }

        [TestMethod()]
        public void MultiplicarPorTest()        
        {
            Complejo numero = new Complejo(4, 5);
            Complejo numMultip = new Complejo(4, 6);
            Complejo retorna = numero.MultiplicarPor(numMultip);
            Complejo esperado = new Complejo(-14, 44);
            Assert.AreEqual(esperado.Imaginario, retorna.Imaginario);
            Assert.AreEqual(esperado.Real, retorna.Real);
        }

        [TestMethod()]
        public void DividirPorTest()    
        {
            Complejo numero = new Complejo(3, 2);
            Complejo numDivisor = new Complejo(1, -2);
            Complejo retorna = numero.DividirPor(numDivisor);
            Complejo esperado = new Complejo(-0.2, 1.6);
            Assert.AreEqual(esperado.Imaginario, retorna.Imaginario);
            Assert.AreEqual(esperado.Real, retorna.Real);
        }
    }
}