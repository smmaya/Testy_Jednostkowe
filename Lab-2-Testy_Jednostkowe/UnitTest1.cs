using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_2_Testy_Jednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        PESELWalidator x, y, z;

        [TestInitialize]
        public void Inicjalizajca()
        {
            x = new PESELWalidator("73020380230");
            y = new PESELWalidator("NNR3746547");
            z = new PESELWalidator("73020380231");
        }

        [TestMethod]
        public void TestSumaKontrolna()
        {
            Assert.AreEqual(0, x.SumaKontrolna());
        }

        [TestMethod]
        public void TestDatyUrodzenia()
        {
            Assert.AreEqual("73", x.DataUrodzenia());
        }

        [TestMethod]
        public void TestPleci()
        {
            Assert.AreEqual("m", x.Plec());
        }

        [TestMethod]
        public void TestSprawdzPesel()
        {
            Assert.AreEqual(true, x.SprawdzPesel());
        }

        [TestMethod]
        public void TestSprawdzNiepoprawnoscPesela()
        {
            Assert.AreEqual(false, y.SprawdzPesel());
        }

        [TestMethod]
        public void TestSprawdzBlednaSumePesela()
        {
            Assert.AreEqual(0, z.SumaKontrolna());
        }

    }

}
