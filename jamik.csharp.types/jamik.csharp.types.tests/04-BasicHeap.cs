using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jamik.csharp.types.tests
{
    [TestClass]
    public class BasicHeap
    {
        [TestMethod]
        public void BasicHeapTest()
        {
            CowBasicHeap betsy = new CowBasicHeap();
            CowBasicHeap georgy = new CowBasicHeap();
            CowBasicHeap clone = betsy;
            int meInt = 8;
        }
    }
}
