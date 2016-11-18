using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarioCSharp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(" #/n##", MarioCSharp.Program.Main(2));
        }
    }
}
