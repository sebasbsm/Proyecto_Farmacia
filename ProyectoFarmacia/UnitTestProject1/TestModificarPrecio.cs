using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestModificarPrecio
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "D:\\FINAL CONSTRUCCION\\pruebaPrecio.csv",
        "pruebaPrecio#csv",
         DataAccessMethod.Sequential),
         DeploymentItem("pruebaPrecio.csv")]
        public void TestModiPrecio()
        {


            int preE, preA;
            preE = Convert.ToInt32(TestContext.DataRow["preE"]);
            preA = Convert.ToInt32(TestContext.DataRow["preA"]);
            if (preE > 0 && preA > 0)
            {
                Assert.AreEqual(preE, preA, "El precio es mayor que 0");
            }

            
        }
    }
}
