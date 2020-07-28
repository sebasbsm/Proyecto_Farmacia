using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farmacia_Final;
namespace UnitTestProject1
{
    [TestClass]
    public class TestProducto
    {
        [TestMethod]
        public void TestMethod1()
        {

            string IDesperado = "0012";
            string recibido;

            recibido = Producto.ID;
            Assert.AreEqual(IDesperado, recibido);
        }

        [TestMethod]
        public void TestMethod2()
        {

            string Nombesperado = "Panadol";
            string recibido;

            recibido = Producto.Nombre;
            Assert.AreEqual(Nombesperado, recibido);
        }

        [TestMethod]
        public void TestMethod3()
        {

            string Provesperado = "Proveedor";
            string recibido;

            recibido = Producto.Proveedor;
            Assert.AreEqual(Provesperado, recibido);
        }

        [TestMethod]
        public void TestMethod4()
        {

            int Stockesperado = 45;
            int recibido;

            recibido = Producto.Stock;
            Assert.AreEqual(Stockesperado, recibido);
        }

        [TestMethod]
        public void TestMethod5()
        {

            string Fechesperado = "15/10/2020";
            DateTime recibido;

            recibido = Producto.Fecha;
            Assert.AreEqual(Fechesperado, recibido);
        }




    }
}
