﻿using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farmacia_Final;

namespace UnitTestProject1
{
    [TestClass]
    public class TestLogin_Confirmacion
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res;
            string exp = @"[a-zA-Z1-9]";
            string a;

            a = Login.Usuario;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);

            string Usuaresperado = "Alex05";
            string recibido;

            recibido = Login_Confirmacion.Usuario;
            Assert.AreEqual(Usuaresperado, recibido);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool res;
            string exp = @"[a-zA-Z1-9]";
            string a;

            a = Login.Contrase;
            System.Text.RegularExpressions.Regex re = new Regex(exp);
            res = re.IsMatch(a);

            Assert.AreEqual(res, true);


            string Passesperado = "alex1234";
            string recibido;

            recibido = Login_Confirmacion.Contrase;
            Assert.AreEqual(Passesperado, recibido);
        }
    }
}
