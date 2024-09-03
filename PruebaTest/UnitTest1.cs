using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography.X509Certificates;

namespace PruebaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompararTresNumerosTest()
        {
            int result = pruebaProgramador.Program.CompareThreeNumbers(1, 3, 4);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void esParTest()
        {
            bool result = pruebaProgramador.Program.isEven(10);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void cuadradoNumeroTest()
        {
            int result = pruebaProgramador.Program.squared(5);
            Assert.AreEqual(25, result);
        }
        [TestMethod]
        public void anagramaTest()
        {
            bool result = pruebaProgramador.Program.isAnagram("Fotolitografía  ", "Litofotografía");
            Assert.AreEqual(true, result);
        }
    }
}