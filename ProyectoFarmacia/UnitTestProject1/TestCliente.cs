using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Farmacia_Final;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCliente
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res;
            string exp = @"[0-9]";
            string a;

            a = Cliente.DNI;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            /*string DNIprueba = "123456";
            string a;
            a = Cliente.DNI;
            Assert.AreEqual(DNIprueba, a);*/
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Cliente.Nombres;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);
            /*string Nombreprueba = "Mario";
            string a;
            a = Cliente.Nombres;
            Assert.AreEqual(Nombreprueba, a);*/
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Cliente.ApellidoPaterno;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);
            //string ApPatprueba = "Luna";
            //string a;
            //a = Cliente.ApellidoPaterno;
            //Assert.AreEqual(ApPatprueba, a);
        }
        [TestMethod]
        public void TestMethod4()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Cliente.ApellidoMaterno;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);
            //string ApMatprueba = "Orellana";
            //string a;
            //a = Cliente.ApellidoMaterno;
            //Assert.AreEqual(ApMatprueba, a);
        }
        [TestMethod]
        public void TestMethod5()
        {
            bool res;
            string exp = @"[a-zA-Z1-9]";
            string a;

            a = Cliente.Direccion;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            //string Dirprueba = "AvSanCarlo";
            //string a;
            //a = Cliente.Direccion;
            //Assert.AreEqual(Dirprueba, a);
        }
        [TestMethod]
        public void TestMethod6()
        {
            
            bool res;
            string exp = @"\b\s*\d{1,2}(/|-)\d{1,2}\1(\d{4}|\d{2})\b";
            string a;

            a = Cliente.Fecha;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);


            //string Fechprueba = "12/10/2020";
            //string a;
            //a = Cliente.Fecha;
            //Assert.AreEqual(Fechprueba, a);
        }
    }
}
