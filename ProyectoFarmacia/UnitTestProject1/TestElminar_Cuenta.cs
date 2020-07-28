using Farmacia_Final;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class TestElminar_Cuenta
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res;
            string exp = @"[a-zA-Z]";
            string a;

            a = Eliminar_Cuenta.Usuario;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            //string Usuaresperado = "Andrei";
            //string recibido;


            //recibido = Eliminar_Cuenta.Usuario;
            //Assert.AreEqual(Usuaresperado, recibido);
        }
    }
}
