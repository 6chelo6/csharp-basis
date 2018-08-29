using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static jamik.csharp.types.MethodExtension;

namespace jamik.csharp.types.tests
{
    [TestClass]
    public class UserDefinedTypes
    {
        [TestMethod]
        public void UserDefinedTypesTest()
        {
            Cow betsy = new Cow();
            Cow georgy = new Cow();
            betsy.Moo();
            betsy.Moo();
            georgy.Moo();
            georgy.Moo();
            georgy.Moo();
            georgy.Moo();
            georgy.Moo();
            georgy.Moo();

            Cat muffin = new Cat();
            muffin.Meow();
        }
    }
}
