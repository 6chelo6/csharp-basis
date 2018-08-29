using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jamik.csharp.types.tests
{
    [TestClass]
    public class TypeFundamentals
    {
        [TestMethod]
        public void TypeFundamentalsTest()
        {
            int myAge = 36;
            System.Int32 myCurrentAge = 36; // -3 -2 -1 0 1 2 3 4 5
            double myWaterBottleOunces = 32.78646; //System.Double 64-bits

            // This will fail
            // int thisIsNuts = myAge + myWaterBottleOunces;

            int yourAge = 25;
            int otherAge = 35;
            int combinedAge = yourAge + otherAge;

            var dfassa = yourAge + myWaterBottleOunces;
            string myName = "Jamie";
            string yourName = "Watcher";
            string combinedNames = myName + yourName;
            int differenceInAge = yourAge - otherAge;

            // This will fail
            // string differenceInNames = myName - yourName;

            // This will fail
            // yourAge.ToUpper();
        }
    }
}
