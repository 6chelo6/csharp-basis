using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jamik.csharp.types.tests
{
    [TestClass]
    public class ValueTypesTest
    {
        [TestMethod]
        public void ValueTypes()
        {
            int i = 5;
            Fraction myFraction = new Fraction(3, 4);

            Cow4 c = new Cow4();
            c.mooCount = 654;
            Console.WriteLine(c.mooCount);
        }
    }
}
