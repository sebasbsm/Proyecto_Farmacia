using System;
using Farmacia_Final;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Nombesperado = "Panadol";
            string recibido;


            recibido = Buscar_Producto.Nombre;
            Assert.AreEqual(Nombesperado, recibido);

        }
    }
}
