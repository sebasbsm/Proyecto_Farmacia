using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestRegistrarServicio
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "D:\\FINAL CONSTRUCCION\\pruebaServicio.csv",
        "pruebaServicio#csv",
         DataAccessMethod.Sequential),
         DeploymentItem("pruebaServicio.csv")]

        public void TestServicios()
        {

            string dniActual, apeActual, nombreActual, servicioActual, dniEs, apeEs, nombreEs, servicioEs;
            dniActual = Convert.ToString(TestContext.DataRow["dniActual"]);
            apeActual = Convert.ToString(TestContext.DataRow["apellidoActual"]);
            nombreActual = Convert.ToString(TestContext.DataRow["nombreActual"]);
            servicioActual = Convert.ToString(TestContext.DataRow["servicioActual"]);
            dniEs = Convert.ToString(TestContext.DataRow["dniE"]);
            apeEs = Convert.ToString(TestContext.DataRow["apellidoE"]);
            nombreEs= Convert.ToString(TestContext.DataRow["nombreE"]);
            servicioEs= Convert.ToString(TestContext.DataRow["servicioE"]);
            if (dniActual != null && apeActual != null && nombreActual != null && servicioActual != null)
            {
                Assert.AreEqual(dniEs,dniActual,"El campo dni no esta vacio");
                Assert.AreEqual(apeEs,apeActual, "El campo dni no esta vacio");
                Assert.AreEqual(nombreEs,nombreActual, "El campo dni no esta vacio");
                Assert.AreEqual(servicioEs,servicioActual, "El campo dni no esta vacio");

            }
        }
    }
}
