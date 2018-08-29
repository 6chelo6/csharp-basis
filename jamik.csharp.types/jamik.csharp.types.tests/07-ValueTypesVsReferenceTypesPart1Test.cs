using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace jamik.csharp.types.tests
{
    [TestClass]
    public class ValueTypesVsReferenceTypesPart1Test
    {
        [TestMethod]
        public void ValueTypesVsReferenceTypesPart1()
        {
            Fraction2 fract1 =
                new Fraction2
                {
                    numerator = 1,
                    denominator = 2
                };
            Fraction2 fract2 = fract1;
            fract2.numerator = 555;
            Console.WriteLine(fract1.numerator);
        }
    }
}
