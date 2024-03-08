using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp65;
 
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AbsAlakzat target = new Háromszög(5, 6, 8);
            double expected = 19;
            double actual = target.Kerület();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            AbsAlakzat target = new Négyzet(5);
            double expected = 20;
            double actual = target.Kerület();
            Assert.AreEqual(expected, actual);
        }
    }
}
