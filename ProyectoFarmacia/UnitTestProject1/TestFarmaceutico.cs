using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farmacia_Final;

namespace UnitTestProject1
{
    [TestClass]
    public class TestFarmaceutico
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res;
            string exp = @"[0-9]";
            string a;

            a = Farmaceutico.DNI;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            //string DNIesperado = "7894561";
            //string recibido;


            //recibido = Farmaceutico.DNI;
            //Assert.AreEqual(DNIesperado, recibido);

        }

        [TestMethod]
        public void TestMethod2()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Farmaceutico.Nombres;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            //string Nombreesperado = "Alex";
            //string recibido;


            //recibido = Farmaceutico.Nombres;
            //Assert.AreEqual(Nombreesperado, recibido);

        }

        [TestMethod]
        public void TestMethod3()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Farmaceutico.ApellidoPaterno;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);
            //string ApPatesperado = "Zapata";
            //string recibido;


            //recibido = Farmaceutico.ApellidoPaterno;
            //Assert.AreEqual(ApPatesperado, recibido);

        }

        [TestMethod]
        public void TestMethod4()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Farmaceutico.ApellidoMaterno;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);
            //string ApMatesperado = "Maravi";
            //string recibido;


            //recibido = Farmaceutico.ApellidoMaterno;
            //Assert.AreEqual(ApMatesperado, recibido);

        }

        [TestMethod]
        public void TestMethod5()
        {
            bool res;
            string exp = @"[a-zA-Z1-9]";
            string a;

            a = Farmaceutico.Direccion;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            //string Diresperado = "AvReal";
            //string recibido;


            //recibido = Farmaceutico.Direccion;
            //Assert.AreEqual(Diresperado, recibido);

        }

        [TestMethod]
        public void TestMethod6()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Farmaceutico.Profesion;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            //string Profesperado = "Quimico Farmaceutico";
            //string recibido;


            //recibido = Farmaceutico.Profesion;
            //Assert.AreEqual(Profesperado, recibido);

        }


    }

}
