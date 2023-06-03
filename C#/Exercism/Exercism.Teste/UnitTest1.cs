namespace Exercism.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Bob01()
        {
            string resp = Bob.Response("Okay if like my  spacebar  quite a bit?   ");
        }

        [TestMethod]
        public void foneNumber()
        {
            (bool ny, bool fake, string final) tupla =   PhoneNumber.Analyze("631-555-1234");
        }
    }
}