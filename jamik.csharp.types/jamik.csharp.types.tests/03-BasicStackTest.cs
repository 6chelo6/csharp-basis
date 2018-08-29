using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jamik.csharp.types.tests
{
    [TestClass]
    public class BasicStackTest
    {
        [TestMethod]
        public void BasicStack()
        {
            BasicStack bs = new BasicStack();
            int myInt = 5;
            int anotherInt = 10;
            bs.Goo();
            double meDouble = 98.3;
            bs.Goo();
        }
    }
}
