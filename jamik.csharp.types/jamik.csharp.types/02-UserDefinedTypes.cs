using System;

namespace jamik.csharp.types
{
    public static class MethodExtension
    {
        static void P(this object o)
        {
            Console.WriteLine(o);
        }

        public class Cow
        {
            int numSteaks;
            int mooCount;
            double pounds;

            public void Moo()
            {
                "Moo".P();
                mooCount++;
            }
        }

        public class Cat
        {
            int numLives= 9;

            public void Meow() { }
        }
    }
}
