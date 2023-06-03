using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercism.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SavingsAccount01()
        {
            Assert.AreEqual(47, SavingsAccount.YearsBeforeDesiredBalance(100.0m, 125.80m));
        }

        [TestMethod]
        public void LogLine01()
        {
            Assert.AreEqual("Operation completed (info)", LogLine.Reformat("[INFO]: Operation completed"));
        }

        [TestMethod]
        public void Bob01()
        {
            string resp = Bob.Response("1, 2, 3");
            Assert.AreEqual("", resp);
        }
    }
}
