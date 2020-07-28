using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farmacia_Final;
namespace UnitTestProject1
{
    [TestClass]
    public class TestServicio_Realizado
    {
        [TestMethod]
        public void TestMethod1()
        {

            string DNIesperado = "45781245";
            string recibido;

            recibido = Servicios_Realizado.DNI;
            Assert.AreEqual(DNIesperado, recibido);
        }

        [TestMethod]
        public void TestMethod2()
        {

            string Nombesperado = "Paul";
            string recibido;

            recibido = Servicios_Realizado.Nombres;
            Assert.AreEqual(Nombesperado, recibido);
        }

        [TestMethod]
        public void TestMethod3()
        {

            string Apellesperado = "Serva";
            string recibido;

            recibido = Servicios_Realizado.Apellidos;
            Assert.AreEqual(Apellesperado, recibido);
        }

        [TestMethod]
        public void TestMethod4()
        {

            string NombServesperado = "Inyeccion";
            string recibido;

            recibido = Servicios_Realizado.NombreServicios;
            Assert.AreEqual(NombServesperado, recibido);
        }

    }
}
